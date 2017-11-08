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
        int GetSuccefulAttackCount(List<AttackDayRecords> attacks);
    }
}
