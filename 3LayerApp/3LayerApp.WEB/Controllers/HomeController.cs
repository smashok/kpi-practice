using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3LayerApp.BLL.Interfaces;
using _3LayerApp.BLL.DTO;
using _3LayerApp.WEB.Models;
using AutoMapper;
using _3LayerApp.BLL.Infrastructure;

namespace _3LayerApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        IOrderService orderService;
        public HomeController(IOrderService serv)
        {
            orderService = serv;
        }
        public ActionResult Index()
        {
            IEnumerable<SaddleDTO> saddleDtos = orderService.GetSaddles();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SaddleDTO, SaddleViewModel>()).CreateMapper();
            var saddles = mapper.Map<IEnumerable<SaddleDTO>, List<SaddleViewModel>>(saddleDtos);
            return View(saddles);
        }
        public ActionResult MakeOrder(int? id)
        {
            try
            {
                SaddleDTO saddle = orderService.GetSaddle(id);
                var order = new OrderViewModel { SaddleId = saddle.Id };

                return View(order);
            }
            catch (ValidationException ex)
            {
                return Content(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult MakeOrder(OrderViewModel order)
        {
            try
            {
                var orderDto = new OrderDTO { SaddleId = order.SaddleId, Address = order.Address, PhoneNumber = order.PhoneNumber };
                orderService.MakeOrder(orderDto);
                return Content("<h2>Ваш заказ принят</h2>");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(order);
        }
                protected override void Dispose(bool disposing)
        {
            orderService.Dispose();
            base.Dispose(disposing);
        }

        
            

        }
}