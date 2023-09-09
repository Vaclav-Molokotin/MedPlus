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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedPlus.UI.Uc
{
    /// <summary>
    /// Логика взаимодействия для UcPatient.xaml
    /// </summary>
    public partial class UcPatient : UserControl
    {
        public MedCard Card;
        public UcPatient(MedCard card)
        {
            Card = card;
            DataContext = Card;
            InitializeComponent();
            TblGender.Text = card.GenderCode == "м"?"Мужской":"Женский";
            TblFullName.Text = $"{Card.LName} {Card.FName} {Card.MName}";
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.Navigate(new PgEditCard(Card));
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.Navigate(new PgEditCard(Card), true);
        }

        public static void FilterLIstByName(ref List<UcPatient> patients, string searchText)
        {
            for(int i = 0; i < patients.Count; i++)
            {
                if (LibMedCard.GetFullName(patients[i].Card).Contains(searchText))
                    patients[i].Visibility = Visibility.Visible;
                else
                    patients[i].Visibility = Visibility.Collapsed;
            }
        }

    }
}
