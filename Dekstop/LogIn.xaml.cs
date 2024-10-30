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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public void RegistrationButton_Click (object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        public void LogInButton_Click (Object sender, RoutedEventArgs e)
        {
            //
        }

        public void Mail_GotFocus (object sender, RoutedEventArgs e)
        {
            if (Mail.Text == "Введите почту")
            {
                Mail.Text = "";
                Mail.Foreground = (Brush)new BrushConverter().ConvertFromString("#313131");
            }
        }

        public void Mail_LostFocus (object sender, RoutedEventArgs e)
        {
            if (Mail.Text == "")
            {
                Mail.Foreground = (Brush)new BrushConverter().ConvertFromString("#C6C6C6");
                Mail.Text = "Введите почту";
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

    }
}
