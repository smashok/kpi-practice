using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using OnionApp.Services.Interfaces;

namespace OnionApp.Controllers
{
    public class HomeController : Controller
    {
        IPhoneRepository repo;
        IOrder order;
        public HomeController(IPhoneRepository r, IOrder o)
        {
            repo = r;
            order = o;
        }
        public ActionResult Index()
        {
            var phones = repo.GetPhoneList();
            return View(phones);
        }

        public ActionResult Buy(int id)
        {
            Phone phone = repo.GetPhone(id);
            order.MakeOrder(phone);
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            repo.Dispose();
            base.Dispose(disposing);
        }
    }
}