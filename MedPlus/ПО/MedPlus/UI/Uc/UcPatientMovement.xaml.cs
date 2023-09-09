using MedPlus.Data.DataBaseModel;
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

namespace MedPlus.UI.Uc
{
    /// <summary>
    /// Логика взаимодействия для UcPatientMovement.xaml
    /// </summary>
    public partial class UcPatientMovement : UserControl
    {
        public PatientMovement movement;
        public UcPatientMovement(PatientMovement movement)
        {
            this.movement = movement;
            DataContext = movement;
            InitializeComponent();
            CmbxDepartment.ItemsSource = LibDepartment.GetDepartments();
            CmbxDischarge.ItemsSource = LibSignOfDischarge.GetSignsOfDischarge();
            
        }
    }
}
