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
    /// Interaction logic for EMOlxaml.xaml
    /// </summary>
    public partial class EMOlxaml : Window
    {
        KursovikEntities5 KursovikEntities5 = new KursovikEntities5();
        public EMOlxaml()
        {
            InitializeComponent();
        }

      
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userOd = KursovikEntities5.EntranceEmployee.FirstOrDefault(a => a.Login == Login.Text && a.Password == pass.Password);
                if (userOd == null)
                {
                    MessageBox.Show("Ошибка в логине или пароле ", "Ошибка авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                    Close();
                }
            }
            catch { }
        }
    }
}
