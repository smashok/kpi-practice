using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab3_1.Model
{
    public class Shop : INotifyPropertyChanged
    {
        private string _name;
        private int _id;

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
                Random random = new Random();
                _id = random.Next(1, 10000);
                OnPropertyChanged("ID");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return "Shop " + _name + "; ID = " + _id;
        }
    }
}
