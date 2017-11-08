using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.Models
{
    public class AttackDayRecords
    {
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public List<AttackDetails> Attacks { get; set; } = new List<AttackDetails>();
    }
}
