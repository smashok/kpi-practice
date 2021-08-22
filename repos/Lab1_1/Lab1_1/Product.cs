using System;

namespace Lab1_1
{
    public class Product
    {
        public string Name;
        public int ID;
        public int Price;

        public Product(string n, int p)
        {
            Random random = new Random();
            Name = n;
            Price = p;
            ID = random.Next(1, 10000);
        }
        public override string ToString()
        {
            return "Product " + Name + "; ID = " + ID + "; cost = " + Price;
        }
    }
}