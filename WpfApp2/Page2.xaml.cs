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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        KursovikEntities3 KursovikEntities3 = new KursovikEntities3();
        public Page2()
        {
            InitializeComponent();
            
        }

 

        private void Adde_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = datePicker1.SelectedDate;
            if (selectedDate.HasValue)
            {
                string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture); // конвертация string в date
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
                KursovikEntities3.Appointment.Add(appointment); // запись данных в базу данных
                KursovikEntities3.SaveChanges(); //сохранение данных
                MessageBox.Show("Пациент успешной зарегистрирован");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
