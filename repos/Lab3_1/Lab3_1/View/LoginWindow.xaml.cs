using Lab3_1.Model;
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
using System.Windows.Shapes;

namespace Lab3_1.View
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MainWindow mainWindow;

        public LoginWindow()
        {
            InitializeComponent();
        }

        public LoginWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text.Length > 0)    
            {
                if (textBoxPassword.Text.Length > 0)       
                {
                    foreach (Customer customer in )
                    {

                    }
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался         
                    }
                    else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку 
        }
    }
}
