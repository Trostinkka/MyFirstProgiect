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
    /// Interaction logic for Adults.xaml
    /// </summary>
    public partial class Adults : Page
    {
       KursovikEntities5 KursovikEntities5 = new KursovikEntities5();
        public Adults()
        {
            InitializeComponent();
            dg1.ItemsSource = KursovikEntities5.Services.ToList();

        }
    }
}
