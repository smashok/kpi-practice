using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using _3LayerApp.DAL.Interfaces;
using _3LayerApp.DAL.Repositories;

namespace _3LayerApp.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}

