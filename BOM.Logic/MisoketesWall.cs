using BOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.Logic
{
    public class MisoketesWall
    {
        /// <summary>
        /// look-up data for current state of walls
        /// </summary>
        private Dictionary<Side, int> lastSuccessfulAttackStrengthLookup = new Dictionary<Side, int>();
        public MisoketesWall()
        {
            lastSuccessfulAttackStrengthLookup[Side.N] = 0;
            lastSuccessfulAttackStrengthLookup[Side.E] = 0;
            lastSuccessfulAttackStrengthLookup[Side.W] = 0;
            lastSuccessfulAttackStrengthLookup[Side.S] = 0;
        }
        /// <summary>
        /// check and assess the attacks and figure out the successful ones
        /// </summary>
        /// <param name="attacks">list of attack details</param>
        public void CheckAttacks(ref List<AttackDayRecords> attacks)
        {
            try
            {
                foreach (var attack in attacks)
                {
                    Dictionary<Side, int> dayWiseMaxAttackStrength = GetLastDayData();
                    foreach (var attackInfo in attack.Attacks)
                    {
                        if (attackInfo.StrengthOfAttack < 0)
                        {
                            throw new Exception();
                        }
                        if (attackInfo.StrengthOfAttack > lastSuccessfulAttackStrengthLookup[attackInfo.SideOfAttack])
                        {
                            if (dayWiseMaxAttackStrength[attackInfo.SideOfAttack] < attackInfo.StrengthOfAttack)
                            {
                                dayWiseMaxAttackStrength[attackInfo.SideOfAttack] = attackInfo.StrengthOfAttack;
                            }
                            attackInfo.IsSuccess = true;
                        }
                    }
                    RaiseWalls(dayWiseMaxAttackStrength);
                }
            }catch(NullReferenceException ex)
            {
                throw new NullReferenceException("It's all safe. No attacks.");
            }
            catch (Exception ex)
            {
                throw new Exception("Something is not correct about the attacks.");
            }
        }
        /// <summary>
        /// raises the walls to the new required height
        /// </summary>
        /// <param name="dayWiseSideMaxAttack">the new height for each wall for a particular day</param>
        private void RaiseWalls(Dictionary<Side, int> dayWiseSideMaxAttack)
        {
            foreach (Side side in dayWiseSideMaxAttack.Keys)
            {
                lastSuccessfulAttackStrengthLookup[side] = dayWiseSideMaxAttack[side];
            }
        }
        private Dictionary<Side, int> GetLastDayData()
        {
            Dictionary<Side, int> dayWiseMaxAttackStrength = new Dictionary<Side, int>();
            foreach (Side side in lastSuccessfulAttackStrengthLookup.Keys)
            {
                dayWiseMaxAttackStrength[side] = lastSuccessfulAttackStrengthLookup[side];
            }
            return dayWiseMaxAttackStrength;
        }
    }
}
