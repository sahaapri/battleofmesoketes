using BOM.Logic;
using BOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOM.API.Controllers
{
    public class AssessAttackController : ApiController
    {
        public int Post(List<AttackDayRecords> attacks)
        {
            AttackRecords attackRecords = new AttackRecords();
            return attackRecords.GetSuccefulAttackCount(attacks);
        }
    }
}
