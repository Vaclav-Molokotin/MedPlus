using MedPlus.Data.DataBaseModel;
using MedPlus.Libs;
using MedPlus.UI.Pg;
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

namespace MedPlus.UI.Wnd
{
    /// <summary>
    /// Логика взаимодействия для WndHome.xaml
    /// </summary>
    public partial class WndHome : Window
    {
        /// <summary>
        /// Конструктор. Инициализирует объекты на окне.
        /// </summary>
        public WndHome()
        {
            InitializeComponent();

            LibUIManager.FrMain = FrMain;
            LibUIManager.LabHeader = LabHeader;
            TblCurrentUser.Text += LibUser.GetFullName(LibUser.CurrentUser);
            setInterface();
        }

        /// <summary>
        /// Метод. Устанавливает ограничение на использование функционала программы в зависимости от роли.
        /// </summary>
        private void setInterface()
        {
            switch (LibUser.CurrentUser.Spr_Role.Name)
            {
                case "Врач":
                case "Средний медперсонал":
                case "Младший медперсонал":
                    BtnReports.IsEnabled = false;
                    break;
            }
        }

        /// <summary>
        /// Обработчик события кнопки "Выход". Инициирует выход из программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик события кнопки "Выход". Открывает окно регистрации пациента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPatients_Click(object sender, RoutedEventArgs e)
        {
            FrMain.Navigate(new PgPatientRegistration());
        }

        /// <summary>
        /// Обработчик события кнопки "Отчёты". Открывает страницу со списком отчётов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReports_Click(object sender, RoutedEventArgs e)
        {
            FrMain.Navigate(new PgReports());
        }

        /// <summary>
        /// Обработчик закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WndLogin wndLogin = new WndLogin();
            wndLogin.Show();
            Owner.Close();
        }

        private void FrMain_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            switch (FrMain.Content.GetType().Name)
            {
                case "PgReports":
                    LabHeader.Content = "Отчёты";
                    break;
                case "PgPatients":
                    LabHeader.Content = "Пациенты";
                    break;
                case "PgEditCard":
                    LabHeader.Content = "Редактирование карты";
                    break;
                case "PgListOfAddmited":
                    LabHeader.Content = "Список поступивших за период";
                    break;
                case "PgPatientMovements":
                    LabHeader.Content = "Движения пациента";
                    break;
                case "PgPatientRegistration":
                    LabHeader.Content = "Регистрация пациента";
                    break;
                case "PgSignalStatement":
                    LabHeader.Content = "Сигнальная ведомость";
                    break;
            }
        }
    }
}
