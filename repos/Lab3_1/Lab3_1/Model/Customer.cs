using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab3_1.Model
{
    public class Customer
    {
        private string _name;
        private int _id;
        private string _username;
        private string _password;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        public override string ToString()
        {
            return "Customer " + Name + "; ID = " + ID;
        }
        public bool CheckLogin(string login, string pass)
        {
            return (login == _username && _password == pass);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
