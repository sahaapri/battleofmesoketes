using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.Models
{
    public class AttackDetails
    {
        public Side SideOfAttack { get; set; }
        public Tribe AttackingTribe { get; set; }
        public string AttackingTribeName { get; set; }
        public int StrengthOfAttack { get; set; }
        public bool IsSuccess { get; set; }
    }
}
