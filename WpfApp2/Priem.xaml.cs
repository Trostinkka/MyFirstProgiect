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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Priem.xaml
    /// </summary>
    public partial class Priem : Window
    {
        KursovikEntities3 KursovikEntities3 = new KursovikEntities3();
        public Priem()
        {
            InitializeComponent();
        }

        private void Adde_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = datePicker1.SelectedDate;
            if (selectedDate.HasValue)
            {
                string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            try
            {
                Random random = new Random();
                int r = random.Next(2, 1000);
                Appointment appointment = new Appointment()
                {
                    id = r,
                    Surname = Surname.Text,
                    Name = Names.Text,
                    Patronymic = Patronymic.Text,
                    DateOfAdmission = selectedDate,
                };
                KursovikEntities3.Appointment.Add(appointment);
                KursovikEntities3.SaveChanges();
                var vv = Convert.ToString(r);
                MessageBox.Show("Вы успешно записались на примём. Номер вашего талона: " + vv + " Дата вашего приёма: " + selectedDate.ToString());

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void talons_Click(object sender, RoutedEventArgs e)
        {
            talons talons = new talons();
            talons.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
