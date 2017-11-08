using BOM.DependencyResolver;
using BOM.Logic;
using BOM.Logic.Contracts;
using BOM.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace BOM.API.Controllers
{
    public class AssessAttackController : ApiController
    {
        private IAttackRecords _attackRecords;
        /// <summary>
        /// property for calling logic layer(using DI)
        /// </summary>
        public IAttackRecords AttackRecords
        {
            get
            {
                return _attackRecords ?? ResolveDependency.Resolve<IAttackRecords>();
            }
            set
            {
                _attackRecords = value;
            }
        }
        //public int Post(List<AttackDayRecords> attacks)
        //{
        //    AttackRecords attackRecords = new AttackRecords();
        //    return attackRecords.GetSuccefulAttackCount(attacks);
        //}


        /// <summary>
        /// To Submit the Attacks for assessing and getting the count of successful attacks
        /// </summary>
        /// <param name="input">array of details of attacks</param>
        /// <returns>count of successful attacks</returns>
        public int Post(string[] input)
        {
            var attacks = ConvertData(input);
            var successfulAttacks = AttackRecords.GetSuccefulAttackCount(attacks);
            return successfulAttacks;
        }
        /// <summary>
        /// function responsible for converting the array of strings into relevant business objects
        /// </summary>
        /// <param name="input">details of the attacks in form of string array</param>
        /// <returns>relevant attacks details in business object</returns>
        private List<AttackDayRecords> ConvertData(string[] input)
        {
            var attacks = new List<AttackDayRecords>();
            foreach (var item in input)
            {
                if (string.IsNullOrEmpty(item))
                {
                    throw new Exception("Attack details missing");
                }
                var data = item.Split(';');
                if (data.Length != 2)
                {
                    throw new Exception("Something is not correct about the attacks.");
                }
                var day = data[0].Split(' ');
                if (day.Length != 2)
                {
                    throw new Exception("Something is not correct about the attacks.");
                }

                var attack = new AttackDayRecords
                {
                    DayId = Convert.ToInt32(day[1])
                };

                var atts = data[1].Split(':');
                foreach (var att in atts)
                {
                    var details = att.Split('-');
                    if (details.Length != 3)
                    {
                        throw new Exception("Something is not correct about the attacks.");
                    }
                    attack.Attacks.Add(new AttackDetails { AttackingTribeName = details[0].Trim(), SideOfAttack = (Side)Enum.Parse(typeof(Side), details[1].Trim()), StrengthOfAttack = Convert.ToInt32(details[2].Trim()) });
                }
                attacks.Add(attack);
            }
            return attacks;
        }
    }
}
