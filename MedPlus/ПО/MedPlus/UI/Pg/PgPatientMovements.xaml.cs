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

namespace MedPlus.UI.Pg
{
    /// <summary>
    /// Логика взаимодействия для PgPatientMovements.xaml
    /// </summary>
    public partial class PgPatientMovements : Page
    {
        MedCard card;
        List<PatientMovement> deleted = new List<PatientMovement>();
        List<PatientMovement> added = new List<PatientMovement>();
        public PgPatientMovements(MedCard card)
        {
            this.card = card;
            InitializeComponent();
            downloadMovements();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            LibUIManager.FrMain.GoBack();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить изменения". Инициирует процесс сохранения изменений в БД.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            LibDB.GetContext().PatientMovements.AddRange(added);
            LibDB.GetContext().PatientMovements.RemoveRange(deleted);

            LibDB.GetContext().SaveChanges();

            deleted.Clear();
            added.Clear();
        }

        private void downloadMovements()
        {
            List<PatientMovement> movements = LibDB.GetContext().PatientMovements.Where(p => p.CardID == card.ID).ToList();
            foreach (PatientMovement movement in movements)
            {
                UcPatientMovement ucPatientMovement = new UcPatientMovement(movement);
                SpContainer.Children.Add(ucPatientMovement);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить". Создаёт новое пустое движение и добавляет его в список добавляемых.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            UcPatientMovement lastUc = (UcPatientMovement)SpContainer.Children[SpContainer.Children.Count - 1];
            if (lastUc.movement.DateTimeDischarge == null)
            {
                MessageBox.Show("Укажите дату для последнего движения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            UcPatientMovement newUc = new UcPatientMovement(new PatientMovement
            {
                CardID = lastUc.movement.CardID,
                DateTimeReceipt = (DateTime)lastUc.movement.DateTimeDischarge
            });
            SpContainer.Children.Add(newUc);
            added.Add(newUc.movement);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить последнее". Удалаяет последнее движение с экрана пользователя и добавлет его в список удаляемых.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteLast_Click(object sender, RoutedEventArgs e)
        {
            int index = SpContainer.Children.Count - 1;

            UcPatientMovement ucPatient = (UcPatientMovement)SpContainer.Children[index];
            deleted.Add(ucPatient.movement);
            SpContainer.Children.Remove(SpContainer.Children[index]);
        }
    }
}
