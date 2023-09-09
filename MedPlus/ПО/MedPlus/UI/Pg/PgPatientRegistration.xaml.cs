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
using Xceed.Wpf.Toolkit;

namespace MedPlus.UI.Pg
{
    /// <summary>
    /// Логика взаимодействия для PgPatientRegistration.xaml
    /// </summary>
    public partial class PgPatientRegistration : Page
    {
        private MedCard card = new MedCard();
        public PgPatientRegistration()
        {
            card.Spr_Department = null;
            card.Spr_Department1 = null;
            DataContext = card;
            InitializeComponent();

            CmbxDocumentType.ItemsSource = LibDocumentType.GetDocumentTypes();
            CmbxCountry.ItemsSource = LibCountry.GetCountries();
            CmbxSocialStatus.ItemsSource = LibSocialStatus.GetSocialStatuses();
            CmbxPaymentType.ItemsSource = LibPaymentType.GetPaymentTypes();
            CmbxHospitalizationType.ItemsSource = LibHospitalizationType.GetHospitaliztionTypes();
            CmbxLPU.ItemsSource = LibLPU.GetAllLPU();
            CmbxDeliveryType.ItemsSource = LibDeliveryType.GetDeliveryTypes();
            CmbxDeliveryPeriod.ItemsSource = LibDeliveryPeriod.GetDeliveryPeriods();
            CmbxSignOfDischarge.ItemsSource = LibSignOfDischarge.GetSignsOfDischarge();
            CmbxDiagnosisLPU.ItemsSource = LibDiagnosis.GetDiagnosis();
            CmbxDiagnosisPO.ItemsSource = LibDiagnosis.GetDiagnosis();
            CmbxDiagnosisDischarge.ItemsSource = LibDiagnosis.GetDiagnosis();
            CmbxInjuryType.ItemsSource = LibInjuryType.GetInjuryTypes();
            CmbxTreatmentOutcome.ItemsSource = LibTreatmentOutcome.GetTreatmentOutcomes();
            CmbxDenial.ItemsSource = LibDenial.GetDenials();
            CmbxSignOfResidence.ItemsSource = LibSignOfResidence.GetSignsOfResidences();
            CmbxDepartmentRecient.ItemsSource = LibDepartment.GetDepartments();
            CmbxDepartmentDischarge.ItemsSource = LibDepartment.GetDepartments();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Найти пациента". Открывает страницу со списком пациентов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFindPatient_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.Navigate(new PgPatients());
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if(CmbxHospitalizationType.SelectedItem == null)
            {
                System.Windows.MessageBox.Show("Укажите вид госпитализации!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }    
            if (ChbxIsRepeated.IsChecked == true)
                card.IsRepeated = 1;
            else
                card.IsRepeated = 0;
            if (RbtnMale.IsChecked == true)
                card.GenderCode = "м";
            else
                card.GenderCode = "ж";
            card.DateTimeReceipt = DateTime.Now;

            if (LibMedCard.AddCard(card))
                System.Windows.MessageBox.Show("Медкарта добавлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                System.Windows.MessageBox.Show("Не удалось добавить медкарту!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            resetFields();
        }

        private void resetFields()
        {
            TbLName.Text = string.Empty;
            TbFName.Text = string.Empty;
            TbMName.Text = string.Empty;
            TbDocumentSeria.Text = string.Empty;
            TbDocumentNumber.Text = string.Empty;
            TbRegion.Text = string.Empty;
            TbArea.Text = string.Empty;
            TbCity.Text = string.Empty;
            TbLocality.Text = string.Empty;
            TbStreet.Text = string.Empty;
            TbHouseNumber.Text = string.Empty;
            TbBuildingNumber.Text = string.Empty;
            TbApartmentNumber.Text = string.Empty;
            TbPhone.Text = string.Empty;
            TbJob.Text = string.Empty;
            TbJobTitle.Text = string.Empty;
            TbPolicySeria.Text = string.Empty;
            TbPolicyNumber.Text = string.Empty;
            TbSNILS.Text = string.Empty;
            TbBrigadeNumber.Text = string.Empty;
            TbDiagnosisDescriptionLPU.Text = string.Empty;
            TbDiagnosisDescriptionPO.Text = string.Empty;
            TbBrigadeNumber.Text = string.Empty;

            DtpkBirthday.SelectedDate = null;
            DtpkDateTimeDischarge.Text = string.Empty;

            CmbxDocumentType.SelectedItem = null;
            CmbxSignOfResidence.SelectedItem = null;
            CmbxCountry.SelectedItem = null;
            CmbxSocialStatus.SelectedItem = null;
            CmbxHospitalizationType.SelectedItem = null;
            CmbxPaymentType.SelectedItem = null;
            CmbxLPU.SelectedItem = null;
            CmbxDeliveryType.SelectedItem = null;
            CmbxDiagnosisLPU.SelectedItem = null;
            CmbxDiagnosisPO.SelectedItem = null;
            CmbxInjuryType.SelectedItem = null;
            CmbxDeliveryPeriod.SelectedItem = null;
            CmbxSignOfDischarge.SelectedItem = null;
            CmbxDiagnosisDischarge.SelectedItem = null;
            CmbxTreatmentOutcome.SelectedItem = null;
            CmbxDenial.SelectedItem = null;
        }

        private void CmbxRegion_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CmbxArea_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CmbxCity_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CmbxLocality_Selected(object sender, RoutedEventArgs e)
        {

        }


    }
}
