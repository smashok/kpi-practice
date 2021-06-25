using Ninject.Modules;

using OnionApp.Domain.Interfaces;
using OnionApp.Infrastructure.Business;
using OnionApp.Infrastructure.Data;
using OnionApp.Services.Interfaces;

namespace OnionApp.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneRepository>().To<PhoneRepository>();
            Bind<IOrder>().To<OnlineOrder>();
        }
    }
}