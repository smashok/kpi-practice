using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3LayerApp.DAL.Entities;

namespace _3LayerApp.BLL.DTO
{
   public class OrderDTO
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
