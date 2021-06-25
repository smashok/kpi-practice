using OnionApp.Domain.Core;

using System.Data.Entity;

namespace OnionApp.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
    }
}