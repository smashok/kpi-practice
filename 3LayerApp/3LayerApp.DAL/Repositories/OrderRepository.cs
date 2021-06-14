using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _3LayerApp.DAL.Entities;
using _3LayerApp.DAL.EF;
using _3LayerApp.DAL.Interfaces;
using System.Data.Entity;

namespace _3LayerApp.DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private SaddleContext db;

        public OrderRepository(SaddleContext context)
        {
            this.db = context;
        }
        public IEnumerable<Order> GetAll()
        {
            return db.Orders.Include(o => o.Saddle);
        }
        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }
        public void Create(Order order)
        {
            db.Orders.Add(order);
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
        public IEnumerable<Order> Find(Func<Order, Boolean> predicate)
        {
            return db.Orders.Include(o => o.Saddle).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Order order = db.Orders.Find(id);
            if (order != null)
                db.Orders.Remove(order);
        }

    }
}