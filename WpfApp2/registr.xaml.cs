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
    /// Interaction logic for registr.xaml
    /// </summary>
    public partial class registr : Window
    {
        KursovikEntities5 KursovikEntities5 = new KursovikEntities5();
        public registr()
        {
            InitializeComponent();
        }

        private void registrs_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random random = new Random();
                int r = random.Next(2, 1000);
                Registration q = new Registration()
                {
                    id = r,
                    Surname = Famil.Text,
                    Name = imya.Text,
                    Patronymic = patron.Text,
                    DateOfBirth = DateTime.Now,
                    OMC_policy = policee.Text,
                    Phone = phonee.Text

                };
                KursovikEntities5.Registration.Add(q);
                KursovikEntities5.SaveChanges();
                MessageBox.Show("Вы успешно зарегестрировались");
                Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка");
            }

        }

       
    }
}
