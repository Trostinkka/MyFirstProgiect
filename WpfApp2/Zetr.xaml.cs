using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Zetr.xaml
    /// </summary>
    public partial class Zetr : Window
    {
        KursovikEntities3 KursovikEntities3 = new KursovikEntities3();
        public Zetr()
        {
            InitializeComponent();
        }

        private void izens_Click(object sender, RoutedEventArgs e)
        {
            var sss = Convert.ToInt32(Idd.Text);
            DateTime? selectedDate = datePicker1.SelectedDate;
            if (selectedDate.HasValue)
            {
                string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture); // конфертация данных из string в date
            }
           
            try
            {
                var userOd = KursovikEntities3.Appointment.FirstOrDefault(a => a.Surname == Surname.Text); //проверка введеной фамилии с той что есть в базе данных

                if (userOd != null)
                {
                    Appointment appointment = new Appointment()
                    {
                        id = sss,
                        Surname = Surname.Text,
                        Name = Names.Text,
                        Patronymic = Otchest.Text,
                        DateOfAdmission = selectedDate

                    };
                    KursovikEntities3.Appointment.AddOrUpdate(appointment);//изменение данных в базе данных
                    KursovikEntities3.SaveChanges();//сохранение 
                    MessageBox.Show("Изменения сохранены");
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
