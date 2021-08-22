using System;

namespace Lab1_1
{
    public class Customer
    {
        public string Name;
        public int ID;
        private string Username;
        private string Pass;

        public Customer(string n, string u, string p)
        {
            Random random = new Random();
            Name = n;
            Username = u;
            Pass = p;
            ID = random.Next(1, 10000);
        }

        public override string ToString()
        {
            return "Customer " + Name + "; ID = " + ID;
        }

        public bool CheckLogin(string login, string pass)
        {
            return (login == Username && Pass == pass);
        }
    }
}