using System;
using System.Collections.Generic;

namespace Lab1_1
{
    class Program
    {
        static Customer customer;
        static void Main(string[] args)
        {
            Database.FillDatabase();
            Login();
        }

        static void Login()
        {
            while (true)
            {
                Console.Write("Please, enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Please, enter your password: ");
                string pass = Console.ReadLine();

                foreach (Customer c in Database.customers)
                {
                    if (c.CheckLogin(username, pass))
                    {
                        Console.WriteLine("Successful login.");
                        customer = c;
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Wrong credits!");
                    }
                }
            }
        }

        static void Menu()
        {
            int selected = 0;
            while (true)
            {
                Console.Write("Search: 1; make order: 2: ");
                if (int.TryParse(Console.ReadLine(), out selected))
                {
                    switch (selected)
                    {
                        case 1:
                            Search();
                            break;
                        case 2:
                            Order();
                            break;
                        default:
                            Console.WriteLine("Wrong number. Please, try again!");
                            break;
                    }
                }
            }
        }

        static void Search()
        {
            while (true)
            {
                Console.Write("Please, enter wanted product name: ");
                string name = Console.ReadLine();
                bool found = false;

                foreach (Shop s in Database.shops)
                {
                    foreach (Product p in s.Products)
                    {
                        if (p.Name == name)
                        {
                            Console.WriteLine(s + "\n" + p + "\n");
                            found = true;
                        }
                    }
                }
                if (found)
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Product not found. Please, try again!");
                }
            }
        }

        static void Order()
        {
            Order order = new Order();
            order.products = new List<Product>();
            while (true)
            {
                Console.Write("Please, enter wanted product name: ");
                string name = Console.ReadLine();
                bool found = false;

                foreach (Shop s in Database.shops)
                {
                    foreach (Product p in s.Products)
                    {
                        if (p.Name == name)
                        {
                            Console.WriteLine(s + "\n" + p + "\n");
                            found = true;

                            Console.Write("Add this to cart (y/n)?");
                            string ans = Console.ReadLine();

                            if (ans == "y")
                            {
                                order.ShopID = s.ID;
                                order.products.Add(p);
                                Console.WriteLine("Product added to cart.");
                                continue;
                            }
                            else if (ans == "n")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Wrong input!");
                            }                            
                        }
                    }
                }
                if (found)
                {
                    Database.orders.Add(order);
                    Menu();
                }
                else
                {
                    Console.WriteLine("Product not found. Please, try again!");
                }
            }
        }
    }
}