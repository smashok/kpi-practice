using Lab3_1.View;
using Lab3_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public enum pages
        {
            login,
            register
        }
        public void OpenPage(pages page)
        {
            switch (page)
            {
                case pages.login:
                    frame.Navigate(new LoginWindow(this));
                    break;
                default:
                    break;
            }
        }
    }
}
