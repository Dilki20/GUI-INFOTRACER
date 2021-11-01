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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using First.Database;
using First.Model;
using System.IO;
using Microsoft.Win32;

namespace First
{
    /// <summary>
    /// Interaction logic for QRSelect.xaml
    /// </summary>
    public partial class QRSelect : UserControl
    {
        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFileDialog = new OpenFileDialog();
      
        public QRSelect()
        {
            InitializeComponent();
        }

        private void btnScanQR_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                imageQR.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                txtQR.Text = decoder.Decode(new QRCodeBitmapImage(new Bitmap(openFileDialog.FileName)));
            }

        }

        private void btnBack2_Click(object sender, RoutedEventArgs e)
        {

            UserDashBoard view = new UserDashBoard();
            view.Show();

        }

        
    }
}
