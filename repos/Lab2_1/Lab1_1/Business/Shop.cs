using System;
using System.Collections.Generic;
namespace Lab1_1
{
    public class Shop
    {
        public string Name;
        public int ID;
        public List<Product> Products;

        public Shop(string n)
        {
            Random random = new Random();
            Name = n;
            Products = new List<Product>();
            ID = random.Next(1, 100000);
        }

        public override string ToString()
        {
            return "Shop " + Name + "; ID = " + ID;
        }
    }
}