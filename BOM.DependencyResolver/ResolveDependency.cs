using BOM.Logic;
using BOM.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace BOM.DependencyResolver
{
    /// <summary>
    /// dependency injection is acheived via this class which uses Unity
    /// </summary>
    public static class ResolveDependency
    {
        static UnityContainer container = new UnityContainer();
        static ResolveDependency()
        {
            container.RegisterType<IAttackRecords, AttackRecords>();
        }
        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
