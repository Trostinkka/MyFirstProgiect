﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void services_Click(object sender, RoutedEventArgs e)
        {
            services services = new services();
            services.Show();
            Close();
            

        }

       
        private void signUp_Click(object sender, RoutedEventArgs e)
        {
            patients patients = new patients(); 
            patients.Show();
            Close();
        }

        private void person_Click(object sender, RoutedEventArgs e)
        {
            EMOlxaml er = new EMOlxaml();
            er.Show();
            Close();
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {

        }
    }
}
