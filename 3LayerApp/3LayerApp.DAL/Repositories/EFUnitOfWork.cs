using System;
using _3LayerApp.DAL.EF;
using _3LayerApp.DAL.Interfaces;
using _3LayerApp.DAL.Entities;

namespace _3LayerApp.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private SaddleContext db;
        private SaddleRepository saddleRepository;
        private OrderRepository orderRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new SaddleContext(connectionString);
        }
        public IRepository<Saddle> Saddles
        {
            get
            {
                if (saddleRepository == null)
                    saddleRepository = new SaddleRepository(db);
                return saddleRepository;
            }
        }
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}