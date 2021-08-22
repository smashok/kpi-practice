using Lab3_1.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab3_1.ViewModel
{
    class DataViewModel : INotifyPropertyChanged
    {
        #region events
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        #region shops
        private Shop _selectedShop;
        public Shop SelectedShop
        {
            get { return _selectedShop; }
            set
            {
                _selectedShop = value;
                OnPropertyChanged("Selected shop");
            }
        }

        public ObservableCollection<Shop> Shops { get; set; }
        public void ShopViewModel()
        {
            Random random = new Random();
            Shops = new ObservableCollection<Shop>
            {
                new Shop{Name = "Cool shop", ID = random.Next(1,10000)},
                new Shop{Name = "Best shop", ID = random.Next(1,10000)}
            };
        }
        public void AddShop()
        {
            Shop shop = new Shop();
            Shops.Add(shop);
            SelectedShop = shop;
        }
        public void DeleteShop()
        {
            if (_selectedShop != null) { Shops.Remove(SelectedShop); }
        }
        #endregion

        #region customers
        private Customer _loginedCustomer;
        public Customer LoginedCustomer
        {
            get { return _loginedCustomer; }
            set
            {
                _loginedCustomer = value;
                OnPropertyChanged("Logined customer");
            }
        }
        public ObservableCollection<Customer> Customers { get; set; }
        public void CustomerViewModel()
        {
            Random random = new Random();
            Customers = new ObservableCollection<Customer>
            {
                new Customer{Name="First customer", ID=random.Next(1, 10000), Username="customerone", Password="pass"}
            };
        }
        public void AddCustomer()
        {
            Customer customer = new Customer();
            Customers.Add(customer);
            LoginedCustomer = customer;
        }
        #endregion
    }
}
