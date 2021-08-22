using System;
using System.Collections.Generic;

namespace Lab1_1
{
    public class Order
    {
        public int ID;
        public int CustomerID;
        public List<Product> products;
        public int ShopID;
        public DateTime Created;
        private int DaysValid;

        public Order(int ci, int si, List<Product> p)
        {
            Random random = new Random();
            ID = random.Next(1, 10000);
            CustomerID = ci;
            ShopID = si;
            products = p;
            Created = DateTime.Now;
        }

        public Order() { }

        public override string ToString()
        {
            return "Order " + ID + " by customer " + CustomerID + " from shop " + ShopID;
        }

        public bool IsValid()
        {
            return Created.AddDays(DaysValid) < DateTime.Now;
        }
    }
}