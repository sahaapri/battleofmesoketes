﻿using BOM.API.Controllers;
using BOM.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.API.Tests.Controllers
{
    //[TestClass]
    //public class AssessAttackControllerTest
    //{
    //    public AssessAttackController AttackAPI = new AssessAttackController();
    //    [ExpectedException(typeof(NullReferenceException), "It's all safe. No attacks.")]
    //    [TestMethod]
    //    public void TestForNullAttacks()
    //    {
    //        int successAttackCount = AttackAPI.Post(null);
    //        Assert.IsTrue(successAttackCount == 0);
    //    }
    //    [ExpectedException(typeof(Exception), "Something is not correct about the attacks.")]
    //    [TestMethod]
    //    public void TestForIncorrectAttackData()
    //    {
    //        var tribe1 = new Tribe { Name = "T1" };
    //        var tribe2 = new Tribe { Name = "T2" };
    //        var tribe3 = new Tribe { Name = "T3" };
    //        var attacks = new List<AttackDayRecords>
    //        {
    //            new AttackDayRecords
    //            {
    //                DayId = 1,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.North, StrengthOfAttack = -1 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.South, StrengthOfAttack = 0 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.West, StrengthOfAttack = 0 }
    //                }
    //            }
    //        };
    //        int successAttackCount = AttackAPI.Post(attacks);
    //        Assert.IsTrue(successAttackCount == 0);
    //    }
    //    [TestMethod]
    //    public void TestForNoAttacks()
    //    {
    //        var attacks = new List<AttackDayRecords>();
    //        int successAttackCount = AttackAPI.Post(attacks);
    //        Assert.IsTrue(successAttackCount == 0);
    //    }
    //    [TestMethod]
    //    public void TestForNoSuccessfulAttacks()
    //    {
    //        var tribe1 = new Tribe { Name = "T1" };
    //        var tribe2 = new Tribe { Name = "T2" };
    //        var tribe3 = new Tribe { Name = "T3" };
    //        var attacks = new List<AttackDayRecords>
    //        {
    //            new AttackDayRecords
    //            {
    //                DayId = 1,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.North, StrengthOfAttack = 0 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.South, StrengthOfAttack = 0 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.West, StrengthOfAttack = 0 }
    //                }
    //            }
    //        };
    //        int successAttackCount = AttackAPI.Post(attacks);
    //        Assert.IsTrue(successAttackCount == 0);
    //    }
    //    [TestMethod]
    //    public void TestForSuccessfulAttackCount1()
    //    {
    //        var tribe1 = new Tribe { Name = "T1" };
    //        var tribe2 = new Tribe { Name = "T2" };
    //        var tribe3 = new Tribe { Name = "T3" };
    //        var attacks = new List<AttackDayRecords>
    //        {
    //            new AttackDayRecords
    //            {
    //                DayId = 1,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.North, StrengthOfAttack = 3 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.South, StrengthOfAttack = 4 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.West, StrengthOfAttack = 2 }
    //                }
    //            },
    //            new AttackDayRecords
    //            {
    //                DayId = 2,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.East, StrengthOfAttack = 4 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.North, StrengthOfAttack = 3 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.South, StrengthOfAttack = 2 }
    //                }
    //            },
    //            new AttackDayRecords
    //            {
    //                DayId = 3,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.West, StrengthOfAttack = 3 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.East, StrengthOfAttack = 5 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.North, StrengthOfAttack = 2 }
    //                }
    //            },
    //        };
    //        int successAttackCount = AttackAPI.Post(attacks);
    //        Assert.IsTrue(successAttackCount == 6);
    //    }

    //    [TestMethod]
    //    public void TestForSuccessfulAttackCount2()
    //    {
    //        var tribe1 = new Tribe { Name = "T1" };
    //        var tribe2 = new Tribe { Name = "T2" };
    //        var tribe3 = new Tribe { Name = "T3" };
    //        var attacks = new List<AttackDayRecords>
    //        {
    //            new AttackDayRecords
    //            {
    //                DayId = 1,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.South, StrengthOfAttack = 4 },
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.North, StrengthOfAttack = 2 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.West, StrengthOfAttack = 3 }
    //                }
    //            },
    //            new AttackDayRecords
    //            {
    //                DayId = 2,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.South, StrengthOfAttack = 5 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.North, StrengthOfAttack = 1 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.North, StrengthOfAttack = 3 }
    //                }
    //            },
    //            new AttackDayRecords
    //            {
    //                DayId = 3,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.West, StrengthOfAttack = 4 },
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.West, StrengthOfAttack = 5 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.North, StrengthOfAttack = 3 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.South, StrengthOfAttack = 4 }
    //                }
    //            },
    //        };
    //        int successAttackCount = AttackAPI.Post(attacks);
    //        Assert.IsTrue(successAttackCount == 7);
    //    }

    //    [TestMethod]
    //    public void TestForSuccessfulAttackCount3()
    //    {
    //        var tribe1 = new Tribe { Name = "T1" };
    //        var tribe2 = new Tribe { Name = "T2" };
    //        var tribe3 = new Tribe { Name = "T3" };
    //        var attacks = new List<AttackDayRecords>
    //        {
    //            new AttackDayRecords
    //            {
    //                DayId = 1,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.North, StrengthOfAttack = 6 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.South, StrengthOfAttack = 6 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.West, StrengthOfAttack = 6 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.East, StrengthOfAttack = 6 }
    //                }
    //            },
    //            new AttackDayRecords
    //            {
    //                DayId = 2,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.East, StrengthOfAttack = 4 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.North, StrengthOfAttack = 3 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.South, StrengthOfAttack = 2 }
    //                }
    //            },
    //            new AttackDayRecords
    //            {
    //                DayId = 3,
    //                Attacks = new List<AttackDetails>
    //                {
    //                    new AttackDetails { AttackingTribe = tribe1, SideOfAttack = Side.West, StrengthOfAttack = 3 },
    //                    new AttackDetails { AttackingTribe = tribe2, SideOfAttack = Side.East, StrengthOfAttack = 5 },
    //                    new AttackDetails { AttackingTribe = tribe3, SideOfAttack = Side.North, StrengthOfAttack = 2 }
    //                }
    //            },
    //        };
    //        int successAttackCount = AttackAPI.Post(attacks);
    //        Assert.IsTrue(successAttackCount == 4);
    //    }
    //}
    [TestClass]
    public class AssessAttackControllerTest
    {
        public AssessAttackController AttackAPI = new AssessAttackController();
        [ExpectedException(typeof(NullReferenceException), "It's all safe. No attacks.")]
        [TestMethod]
        public void TestForNullAttacks()
        {
            int successAttackCount = AttackAPI.Post(null);
            Assert.IsTrue(successAttackCount == 0);
        }
        [ExpectedException(typeof(Exception), "Something is not correct about the attacks.")]
        [TestMethod]
        public void TestForIncorrectAttackData()
        {
            var attackData = new string[]
            {
                "Day 1; Tribe 1 - N - -1: Tribe 2 - S - 0: Tribe 3 - W - 0"
            };
            
            int successAttackCount = AttackAPI.Post(attackData);
            Assert.IsTrue(successAttackCount == 0);
        }
        [ExpectedException(typeof(Exception), "Attack details missing")]
        [TestMethod]
        public void TestForNoAttacks()
        {
            var attacks = new string[3];
            int successAttackCount = AttackAPI.Post(attacks);
            Assert.IsTrue(successAttackCount == 0);
        }
        [TestMethod]
        public void TestForNoSuccessfulAttacks()
        {
            var attackData = new string[]
            {
                "Day 1; Tribe 1 - N - 0: Tribe 2 - S - 0: Tribe 3 - W - 0",
            };
            int successAttackCount = AttackAPI.Post(attackData);
            Assert.IsTrue(successAttackCount == 0);
        }
        [TestMethod]
        public void TestForSuccessfulAttackCount1()
        {
            var attackData = new string[]
            {
                "Day 1; Tribe 1 - N - 3: Tribe 2 - S - 4: Tribe 3 - W - 2",
                "Day 2; Tribe 1 - E - 4: Tribe 2 - N - 3: Tribe 3 - S - 2",
                "Day 3; Tribe 1 - W - 3: Tribe 2 - E - 5: Tribe 3 - N - 2",
            };
            int successAttackCount = AttackAPI.Post(attackData);
            Assert.IsTrue(successAttackCount == 6);
        }

        [TestMethod]
        public void TestForSuccessfulAttackCount2()
        {
            var attackData = new string[]
            {
                "Day 1; Tribe 1 - S - 4: Tribe 2 - N - 2: Tribe 3 - W - 3",
                "Day 2; Tribe 1 - S - 5: Tribe 2 - N - 1: Tribe 3 - N - 3",
                "Day 3; Tribe 1 - W - 4: Tribe 1 - W - 5: Tribe 2 - N - 3: Tribe 3 - S - 4",
            };
            int successAttackCount = AttackAPI.Post(attackData);
            Assert.IsTrue(successAttackCount == 7);
        }

        [TestMethod]
        public void TestForSuccessfulAttackCount3()
        {
            var attackData = new string[]
            {
                "Day 1; Tribe 1 - N - 6: Tribe 2 - S - 6: Tribe 3 - W - 6: Tribe 3 - E - 6",
                "Day 2; Tribe 1 - E - 4: Tribe 2 - N - 3: Tribe 3 - S - 2",
                "Day 3; Tribe 1 - W - 3: Tribe 1 - E - 5: Tribe 2 - N - 2",
            };
            int successAttackCount = AttackAPI.Post(attackData);
            Assert.IsTrue(successAttackCount == 4);
        }
    }
}
