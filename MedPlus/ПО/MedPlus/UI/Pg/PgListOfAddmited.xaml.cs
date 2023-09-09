using MedPlus.Data.DataBaseModel;
using MedPlus.Libs;
using MedPlus.Libs.Entities;
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

namespace MedPlus.UI.Pg
{
    /// <summary>
    /// Логика взаимодействия для PgListOfAddmited.xaml
    /// </summary>
    public partial class PgListOfAddmited : Page
    {
        /// <summary>
        /// Конструктор. Инициирует элементы на окне и выставляет текущий день в поле выбора даты.
        /// </summary>
        public PgListOfAddmited()
        {
            InitializeComponent();
            DtpkDateBegin.SelectedDate = DateTime.Today.AddDays(-1);
            DtpkDateEnd.SelectedDate = DateTime.Today;
        }

        /// <summary>
        /// Обработчик изменения размеров страницы. Задаёт ширину поля выбора даты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DtpkDateBegin.Width = Width / 4;
            DtpkDateEnd.Width = Width / 4;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сформировать". Получает сигнальную ведомость из базы данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateBegin = (DateTime)DtpkDateBegin.SelectedDate;
            DateTime dateEnd = (DateTime)DtpkDateEnd.SelectedDate;

            List<Sp_ListOfAddmited_Result> report = LibReports.GetListOfAddmited(dateBegin, dateEnd);
            DgContainer.ItemsSource = report;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Назад". Возвращает страницу списка отчётов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.GoBack();
        }
    }
}
