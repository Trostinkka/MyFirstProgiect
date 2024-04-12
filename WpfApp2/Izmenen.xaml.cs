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
    /// Interaction logic for Izmenen.xaml
    /// </summary>
    public partial class Izmenen : Window
    {
       KursovikEntities3 KursovikEntities3 = new KursovikEntities3();
        public Izmenen()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rasp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sertc_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var userOd = KursovikEntities3.Appointment.FirstOrDefault(a => a.Surname == loinn.Text);
                if (userOd == null)
                {
                    MessageBox.Show("Клиент не найдет. Проверьте фамилию клиента ", "Ошибка поиска!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Zetr window1 = new Zetr();
                    window1.Show();
                    Close();


                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
