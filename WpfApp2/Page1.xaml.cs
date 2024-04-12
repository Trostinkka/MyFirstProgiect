using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data.Entity;
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
    /// Interaction logic for Page1.xaml
    /// </summary>

    public partial class Page1 : Page
    {
        KursovikEntities3 KursovikEntities3 = new KursovikEntities3();
        
        public Page1()
        {
            InitializeComponent();
            loadd();
            


        }

        private void loadd()
        {
            var data = from r in KursovikEntities3.Appointment select r;
            dg1.ItemsSource = data.ToList();
        }

        private void added_Click(object sender, RoutedEventArgs e)
        {
            int appot = (dg1.SelectedItem as Appointment).id; // поиск данных по id
            Appointment apt = (from r in KursovikEntities3.Appointment where r.id == appot select r).SingleOrDefault(); 
            KursovikEntities3.Appointment.Remove(apt); // удаление данных из базы данных
            KursovikEntities3.SaveChanges(); // сохрание
            dg1.ItemsSource = KursovikEntities3.Appointment.ToList(); // обновить DateGrid

        }
        
   

      

        private void izme_Click(object sender, RoutedEventArgs e)
        {
            Zetr zetr = new Zetr();
            zetr.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tbx = sender as TextBox;
            if (tbx.Text != "")// если tbx не равно пустому месту то
            {
                var filteList = KursovikEntities3.Appointment.Where(x => x.Surname.ToLower().Contains(tbx.Text.ToLower()));// сортируем datagrid по фамилии 
                dg1.ItemsSource = null; //удаляем его
                dg1.ItemsSource = filteList.ToList();// и выводим наш отфильтрованый
            }
            else// или же
            {
                dg1.ItemsSource = KursovikEntities3.Appointment.ToList();//заполняем datagrid из базы данных
            }
        }

      

        private void obnov_Click(object sender, RoutedEventArgs e)
        {
            loadd();
        }
    }
}

       
   

