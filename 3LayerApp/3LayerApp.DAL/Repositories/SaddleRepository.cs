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
    public class SaddleRepository : IRepository<Saddle>
    {
        private SaddleContext db;

        public SaddleRepository(SaddleContext context)
        {
            this.db = context;
        }

        public IEnumerable<Saddle> GetAll()
        {
            return db.Saddles;

        }
        public Saddle Get(int id)
        {
        return db.Saddles.Find(id);
            }
    public void Create(Saddle book)
    {
        db.Saddles.Add(book);
    }

    public void Update(Saddle book)
    {
        db.Entry(book).State = EntityState.Modified;
    }

    public IEnumerable<Saddle> Find(Func<Saddle, Boolean> predicate)
        {
            return db.Saddles.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Saddle book = db.Saddles.Find(id);
            if (book != null)
                db.Saddles.Remove(book);
        }
    }
}