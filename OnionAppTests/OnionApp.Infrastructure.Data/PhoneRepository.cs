using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnionApp.Infrastructure.Data
{
    public class PhoneRepository : IPhoneRepository
    {
        private OrderContext db;

        public PhoneRepository()
        {
            this.db = new OrderContext();
        }
        public IEnumerable<Phone> GetPhoneList()
        {
            return db.Phones.ToList();
        }

        public Phone GetPhone(int id)
        {
            return db.Phones.Find(id);
        }

        public void Create(Phone phone)
        {
            db.Phones.Add(phone);
        }

        public void Update(Phone phone)
        {
            db.Entry(phone).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Phone phone = db.Phones.Find(id);
            if (phone != null)
                db.Phones.Remove(phone);
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
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
