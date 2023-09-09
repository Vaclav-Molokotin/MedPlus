using MedPlus.Data.DataBaseModel;
using MedPlus.Libs;
using MedPlus.Libs.DB;
using MedPlus.UI.Uc;
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
using System.Windows.Threading;

namespace MedPlus.UI.Pg
{
    /// <summary>
    /// Логика взаимодействия для PgPatients.xaml
    /// </summary>
    public partial class PgPatients : Page
    {
        private const int pageSize = 200;
        private int pageCount = 0;
        private int currentPage = 0;
        private List<MedCard> cards = new List<MedCard>();
        List<UcPatient> patients = new List<UcPatient>();

        public PgPatients()
        {
            InitializeComponent();
            updateCards();
        }

        private void downloadCards()
        {
            SpContainer.Children.Clear();
            patients.Clear();
            for (int i = 0; i < cards.Count; i++)
            {
                UcPatient ucPatient = new UcPatient(cards[i]);
                SpContainer.Children.Add(ucPatient);
                patients.Add(ucPatient);
                UpdateLayout();
            }
        }
        
        /// <summary>
        /// Обработчик нажатия кнопки "Обновить". Инициирует процесс обновления записей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            currentPage = 0;
            BtnPreviousRecords.Visibility = Visibility.Collapsed;
            BtnNextRecords.Visibility = Visibility.Visible;
            updateCards();
            downloadCards();
        }

        /// <summary>
        /// Метод. Обновляет список пациентов.
        /// </summary>
        private void updateCards()
        {
            cards = LibMedCard.GetMedCards(pageSize * currentPage, TbSearch.Text);
            int rowsCount = LibMedCard.GetCountOfCards(TbSearch.Text);
            if (rowsCount % pageSize == 0)
                pageCount = rowsCount / pageSize;
            else
                pageCount = rowsCount / pageSize + 1;
        }

        /// <summary>
        /// Обработчик изменения текста в поле поиска.                                                
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            currentPage = 0;
            BtnPreviousRecords.Visibility = Visibility.Collapsed;
            if (pageCount > 1)
                BtnNextRecords.Visibility = Visibility.Visible;
            else
                BtnNextRecords.Visibility = Visibility.Visible;
            updateCards();
            downloadCards();
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            downloadCards();
        }

        private void BtnPreviousRecords_Click(object sender, RoutedEventArgs e)
        {
            currentPage--;
            if (currentPage == 0)
                BtnPreviousRecords.Visibility = Visibility.Collapsed;
            BtnNextRecords.Visibility = Visibility.Visible;
            updateCards();
            downloadCards();
        }

        private void BtnNextRecords_Click(object sender, RoutedEventArgs e)
        {
            currentPage++;
            if (currentPage == pageCount - 1)
                BtnNextRecords.Visibility = Visibility.Collapsed;
            BtnPreviousRecords.Visibility = Visibility.Visible;
            updateCards();
            downloadCards();
        }
    }
}
