using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOM.Models;
using BOM.Logic.Contracts;

namespace BOM.Logic
{
    public class AttackRecords : IAttackRecords
    {
        private MisoketesWall _assessAttacks;
        public MisoketesWall _AssessAttacks
        {
            get
            {
                return _assessAttacks ?? new MisoketesWall();
            }
            set
            {
                _assessAttacks = value;
            }
        }
        public int GetSuccefulAttackCount(List<AttackDayRecords> attacks)
        {
            _AssessAttacks.CheckAttacks(ref attacks);
            int successCount = attacks.SelectMany(a => a.Attacks).Where(a => a.IsSuccess == true).Count();
            return successCount;
        }
    }
}
