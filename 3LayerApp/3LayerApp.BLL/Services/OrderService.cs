using System;
using _3LayerApp.BLL.DTO;
using _3LayerApp.DAL.Entities;
using _3LayerApp.BLL.BusinessModels;
using _3LayerApp.DAL.Interfaces;
using _3LayerApp.BLL.Infrastructure;
using _3LayerApp.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace _3LayerApp.BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeOrder(OrderDTO orderDto)
        {
            Saddle saddle = Database.Saddles.Get(orderDto.SaddleId);
            if (saddle == null)
                throw new ValidationException("Saddle not found", "");

            decimal sum = new Discount(0.1m).GetDiscountedPrice(saddle.Price);
            Order order = new Order
            {
                Date = DateTime.Now,
                Address = orderDto.Address,
                SaddleId = saddle.Id,
                Sum = sum,
                PhoneNumber = orderDto.PhoneNumber
            };
            Database.Orders.Create(order);
            Database.Save();
        
        }
       
        public SaddleDTO GetSaddle(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id седла", "");
            var saddle = Database.Saddles.Get(id.Value);
            if (saddle == null)
                throw new ValidationException("Седло не найдено", "");

            return new SaddleDTO
            {
                BrandName = saddle.BrandName,
                Id = saddle.Id,
                Name = saddle.Name,
                Price = saddle.Price
            };
        
        }
        public void Dispose()
        {
            Database.Dispose();
        }
        public IEnumerable<SaddleDTO> GetSaddles()
        {

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Saddle, SaddleDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Saddle>, List<SaddleDTO>>(Database.Saddles.GetAll());
        }

    }
}
