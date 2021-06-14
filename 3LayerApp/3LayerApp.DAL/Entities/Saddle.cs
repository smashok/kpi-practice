using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3LayerApp.DAL.Entities
{
    public class Saddle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}