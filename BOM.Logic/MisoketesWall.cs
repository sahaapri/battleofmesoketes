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
        private Dictionary<Side, int> lastSuccessfulAttackStrengthLookup = new Dictionary<Side, int>();
        public MisoketesWall()
        {
            lastSuccessfulAttackStrengthLookup[Side.North] = 0;
            lastSuccessfulAttackStrengthLookup[Side.East] = 0;
            lastSuccessfulAttackStrengthLookup[Side.West] = 0;
            lastSuccessfulAttackStrengthLookup[Side.South] = 0;
        }
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
