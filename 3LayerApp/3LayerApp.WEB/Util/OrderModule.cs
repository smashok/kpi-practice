using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using _3LayerApp.BLL.Services;
using _3LayerApp.BLL.Interfaces;

namespace _3LayerApp.WEB.Util
{
    public class OrderModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
        }
    }
}