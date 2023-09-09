using MedPlus.Data.DataBaseModel;
using MedPlus.Libs;
using MedPlus.Libs.DB;
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
    /// Логика взаимодействия для PgEditCard.xaml
    /// </summary>
    public partial class PgEditCard : Page
    {
        private MedCard card;
        private Spr_PaymentType oldPaymentType;
        private bool readOnly;

        public PgEditCard(MedCard medCard, bool readOnly = false)
        {
            this.readOnly = readOnly;
            card = medCard;
            LibMedCard.SetMedCardDependences(card);
            DataContext = card;
            InitializeComponent();
            setInterface();

            oldPaymentType = card.Spr_PaymentType;

            RbtnFemale.IsChecked = card.GenderCode == "ж";
            ChbxIsRepeated.IsChecked = card.IsRepeated == 1;

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
            this.readOnly = readOnly;

            
        }

        /// <summary>
        /// Обработчик события. Инициирует процесс сохранения изменений в редактируемой карте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            card.GenderCode = (bool)RbtnFemale.IsChecked ? "ж":"м";
            card.IsRepeated = (bool)ChbxIsRepeated.IsChecked ? 1:0;
            if (LibMedCard.UpdateMedCard(card))
            {
                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                if (oldPaymentType != null)
                {
                    if (oldPaymentType.ID != card.PaymentTypeID)
                    {
                        ChangesOfPaymentType changesOfPaymentType = new ChangesOfPaymentType
                        {
                            OldPaymentTypeID = oldPaymentType.ID,
                            NewPaymentTypeID = (int)card.PaymentTypeID,
                            DateTime = DateTime.Now,
                            MedCard = card,
                            User = LibUser.CurrentUser
                        };

                        LibDB.GetContext().ChangesOfPaymentTypes.Add(changesOfPaymentType);
                        LibDB.GetContext().SaveChanges();
                        MessageBox.Show("Тип оплаты был изменён!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                LibUIManager.FrMain.GoBack();
            }
            else
                MessageBox.Show("Данные не были сохранены!", "Ошибка при обновлении", MessageBoxButton.OK, MessageBoxImage.Error);
            
        }

        /// <summary>
        /// Обработчик события. Возвращает на страницу списка пользователей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.GoBack();
        }

        /// <summary>
        /// Метод. Реализует разграничение функционала в зависимости от роли текущего пользователя.
        /// </summary>
        private void setInterface()
        {
            Spr_Role role = LibUser.CurrentUser.Spr_Role;
            if ((role.Name != "Врач-статист" && card.Spr_TreatmentOutcome != null) || readOnly)
            {
                return;
            }
            switch (role.Name)
            {
                case "Врач":
                    break;
                case "Младший медперсонал":
                case "Экономист":
                case "Врач-статист":
                    TbLName.IsEnabled = true;
                    TbFName.IsEnabled = true;
                    TbMName.IsEnabled = true;
                    RbtnFemale.IsEnabled = true;
                    RbtnMale.IsEnabled = true;
                    CmbxDocumentType.IsEnabled = true;
                    TbDocumentSeria.IsEnabled = true;
                    TbDocumentNumber.IsEnabled = true;
                    DtpkBirthday.IsEnabled = true;
                    CmbxSignOfResidence.IsEnabled = true;
                    CmbxCountry.IsEnabled = true;
                    TbStreet.IsEnabled = true;
                    TbHouseNumber.IsEnabled = true;
                    TbBuildingNumber.IsEnabled = true;
                    TbApartmentNumber.IsEnabled = true;
                    TbPhone.IsEnabled = true;
                    CmbxSocialStatus.IsEnabled = true;
                    TbJob.IsEnabled = true;
                    TbJobTitle.IsEnabled = true;
                    CmbxHospitalizationType.IsEnabled = true;
                    CmbxPaymentType.IsEnabled = true;
                    TbPolicySeria.IsEnabled = true;
                    TbPolicyNumber.IsEnabled = true;
                    TbSNILS.IsEnabled = true;
                    CmbxLPU.IsEnabled = true;
                    CmbxDeliveryType.IsEnabled = true;
                    TbBrigadeNumber.IsEnabled = true;
                    CmbxDiagnosisLPU.IsEnabled = true;
                    TbDiagnosisDescriptionLPU.IsEnabled = true;
                    CmbxDiagnosisPO.IsEnabled = true;
                    TbDiagnosisDescriptionPO.IsEnabled = true;
                    ChbxIsRepeated.IsEnabled = true;
                    CmbxInjuryType.IsEnabled = true;
                    CmbxDeliveryPeriod.IsEnabled = true;
                    DtpkDateTimeDischarge.IsEnabled = true;
                    CmbxDiagnosisDischarge.IsEnabled = true;
                    CmbxTreatmentOutcome.IsEnabled = true;
                    CmbxDenial.IsEnabled = true;
                    break;
                case "Средний медперсонал":
                    break;
            }            
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Движения пациента". Открывает страницу движений текущего пациента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenMovements_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.Navigate(new PgPatientMovements(card));
        }
    }
}
