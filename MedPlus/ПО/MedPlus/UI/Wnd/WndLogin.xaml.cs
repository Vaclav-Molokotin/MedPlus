using MedPlus.Data.DataBaseModel;
using MedPlus.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace MedPlus.UI.Wnd
{
    /// <summary>
    /// Логика взаимодействия для WndLogin.xaml
    /// </summary>
    public partial class WndLogin : Window
    {
        /// <summary>
        /// Конструктор. Инициализирует элементы окна.
        /// </summary>
        public WndLogin()
        {
            InitializeComponent();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ImgLogo.Height = Height / 4.5;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ImgLogo.Height = Height / 4.5;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Войти". Инициирует процесс аутентификации и авторизации пользователя пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            login();
        }

        /// <summary>
        /// Метод. Инициирует процесс входа в систему.
        /// </summary>
        private void login()
        {
            string login = TbLogin.Text;
            string password = (bool)ChbxPassword.IsChecked ? TbPassword.Text : PwbxPassword.Password;

            User user = LibUser.GetUserByLoginPassword(login, password);

            if (user != null)
            {
                LibUser.CurrentUser = user;

                MessageBox.Show($"Вы вошли под пользователем {LibUser.GetFullName(user)} в режиме {user.Spr_Role.Name}",
                    "Успешный вход",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                WndHome wnd = new WndHome
                {
                    Owner = this
                };
                wnd.Show();
                Hide();
            }
            else
            {
                MessageBox.Show($"Неправильный логин или пароль!",
                    "Ошибка при входе в систему",
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            }
        }

        private void ChbxPassword_Click(object sender, RoutedEventArgs e)
        {
            if (ChbxPassword.IsChecked == true)
            {
                PwbxPassword.Visibility = Visibility.Collapsed;
                TbPassword.Visibility = Visibility.Visible;

                TbPassword.Text = PwbxPassword.Password;
            }
            else
            {
                PwbxPassword.Visibility = Visibility.Visible;
                TbPassword.Visibility = Visibility.Collapsed;

                PwbxPassword.Password = TbPassword.Text;
            }
        }


    }
}
