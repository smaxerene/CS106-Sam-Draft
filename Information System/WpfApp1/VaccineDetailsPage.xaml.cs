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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for VaccineDetailsPage.xaml
    /// </summary>
    public partial class VaccineDetailsPage : Window
    {
        public VaccineDetailsPage()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            Close();
        }

        //Account 
        private void btnClosePopup_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void btnShowPopup_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnShowPopup)
            {
                myPopup.IsOpen = true;
            }
        }

        private void EditUpload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateCert_Click(object sender, RoutedEventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.Show();
            Close();
        }
    }
}