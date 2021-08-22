using System.Collections.Generic;

namespace Lab1_1
{
    public static class Database
    {
        public static bool logined = false;
        public static List<Customer> customers = new List<Customer>();
        public static List<Shop> shops = new List<Shop>();
        public static List<Product> products = new List<Product>();
        public static List<Order> orders = new List<Order>();

        public static void FillDatabase()
        {
            customers.Add(new Customer("TestCustomer", "test", "password"));

            shops.Add(new Shop("Cool shop"));
            shops.Add(new Shop("Best shop"));

            products.Add(new Product("Product1", 120));
            shops[0].Products.Add(new Product("Product1", 120));

            products.Add(new Product("Product2", 70));
            shops[0].Products.Add(new Product("Product2", 70));
            shops[1].Products.Add(new Product("Product2", 70));
        }
    }
}
