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

        public void RegistrationButton_Click (object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "Введите имя пользователя" || UserName.Text.Length < 3)
            {
                MessageBox.Show("Имя пользователя должно содержать не менее трех символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (!CheckEmail())
            {
                MessageBox.Show("Почта некорректна", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (Password.Password != PasswordConfirm.Password)
            {
                MessageBox.Show("Пароль и его подтверждение должны совпадать", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (Password.Password.Length < 6)
            {
                MessageBox.Show("Пароль должен состоять не менее чем из шести символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MainEmpty mainEmpty = new MainEmpty();
                mainEmpty.Show();
                this.Close();
            }
        }

        private bool CheckEmail()
        {
            if (Mail.Text == "exam@yandex.ru")
            {
                return false;
            }

            return Regex.IsMatch(Mail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void Input_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                e.Handled = true;
            }
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
