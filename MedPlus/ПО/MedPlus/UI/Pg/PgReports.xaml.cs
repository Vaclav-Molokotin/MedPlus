using MedPlus.Libs;
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
    /// Логика взаимодействия для PgReports.xaml
    /// </summary>
    public partial class PgReports : Page
    {
        public PgReports()
        {
            InitializeComponent();
        }

        private void BtnOpenSignalStatement_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.Navigate(new PgSignalStatement());
        }

        private void BtnOpenListOfAdmitted_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.Navigate(new PgListOfAddmited());
        }
    }
}
