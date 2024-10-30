using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        public void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            //
        }
        
        public void BackButton_Click (object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        public void UserName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "Введите имя пользователя")
            {
                UserName.Text = "";
                UserName.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void UserName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                UserName.Text = "Введите имя пользователя";
            }
        }

        public void Mail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Mail.Text == "exam@yandex.ru")
            {
                Mail.Text = "";
                Mail.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void Mail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Mail.Text == "")
            {
                Mail.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                Mail.Text = "exam@yandex.ru";
            }
        }

        public void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Password == "")
            {
                PasswordPlaceholder.Visibility = Visibility.Hidden;
            }
        }

        public void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Password == "")
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        public void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Password.Password != "")
            {
                PasswordPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        public void PasswordConfirm_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordConfirm.Password == "")
            {
                PasswordConfirmPlaceholder.Visibility = Visibility.Hidden;
            }
        }

        public void PasswordConfirm_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordConfirm.Password == "")
            {
                PasswordConfirmPlaceholder.Visibility = Visibility.Visible;
            }
        }

        public void PasswordConfirm_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordConfirm.Password != "")
            {
                PasswordConfirmPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordConfirmPlaceholder.Visibility = Visibility.Visible;
            }
        }
    }
}
