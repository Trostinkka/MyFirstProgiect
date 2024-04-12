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
    /// Interaction logic for patients.xaml
    /// </summary>
    public partial class patients : Window
    {
        KursovikEntities5 KursovikEntities5 = new KursovikEntities5();
        public patients()
        {
            InitializeComponent();
        }

        private void services_Click(object sender, RoutedEventArgs e)
        {
            services services = new services();
            services.Show();
            Close();
        }

        

        private void registr_Click(object sender, RoutedEventArgs e)
        {
            registr registr = new registr();
            registr.Show();
            
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                var userOd = KursovikEntities5.Registration.FirstOrDefault(a => a.OMC_policy == police.Text); //проверка введеного полиса ОМС с тем что есть в базе данных
                if (userOd == null)
                {



                    MessageBox.Show("Ошибка. Провверьте полис ОМС ", "Ошибка авторизации!", MessageBoxButton.OK, MessageBoxImage.Error); // вывод окна ошибки




                }
                else
                {
                    Priem priem = new Priem(); 
                    priem.Show(); //переход на другую страницу
                    Close();
                }
            }
            catch { }
        }
    }
}
