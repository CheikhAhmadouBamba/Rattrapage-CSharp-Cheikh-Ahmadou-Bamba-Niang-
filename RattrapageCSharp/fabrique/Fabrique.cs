using RattrapageCSharp.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RattrapageCSharp.fabrique
{
    class Fabrique
    {
        public static IService getInstanceService()
        {
            return new Service()
            {
                //Context = new MasterEntities(),
            };
        }
    }
}
