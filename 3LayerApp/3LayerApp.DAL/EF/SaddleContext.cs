using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using _3LayerApp.DAL.Entities;

namespace _3LayerApp.DAL.EF
{
    public class SaddleContext : DbContext
    {
        public DbSet<Saddle> Saddles { get; set; }
        public DbSet<Order> Orders { get; set; }

        static SaddleContext()
        {
            Database.SetInitializer<SaddleContext>(new StoreDbInitializer());
        }
        public SaddleContext(string connectionString)
            : base(connectionString)
        {

        }
    }
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<SaddleContext>
    {
        protected override void Seed(SaddleContext db)
        {
            db.Saddles.Add(new Saddle { Name = "2GS Jumping saddle", BrandName = "CWD", Price = 5500 });
            db.Saddles.Add(new Saddle { Name = "Flat seat Jumping saddle", BrandName = "Butet Saumur", Price = 5200 });
            db.Saddles.Add(new Saddle { Name = "Signature Dressage saddle", BrandName = "Antares", Price = 4500 });
            db.Saddles.Add(new Saddle { Name = "Michael Robert Jumping saddle", BrandName = "Prestige", Price = 3000 });
            db.SaveChanges();
        }
    }
}