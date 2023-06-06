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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for QRPage.xaml
    /// </summary>
    public partial class QRPage : Window
    {
        public QRPage()
        {
            InitializeComponent();
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

        private void QR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
