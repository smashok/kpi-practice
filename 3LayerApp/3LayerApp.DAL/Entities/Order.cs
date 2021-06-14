using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3LayerApp.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime Date { get; set; }

        public int SaddleId { get; set; }
        public Saddle Saddle { get; set; }
    }
}