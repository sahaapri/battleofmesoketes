using BOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.Logic.Contracts
{
    public interface IAttackRecords
    {
        /// <summary>
        /// get the number of successful attacks 
        /// </summary>
        /// <param name="attacks">list of attack details</param>
        /// <returns>count of successful attacks</returns>
        int GetSuccefulAttackCount(List<AttackDayRecords> attacks);
    }
}
