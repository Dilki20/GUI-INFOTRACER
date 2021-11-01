using Microsoft.Win32;
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
//using System.Windows.Forms;

namespace First
{
    /// <summary>
    /// Interaction logic for ScanQR.xaml
    /// </summary>
    public partial class ScanQR : UserControl
    {
        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public ScanQR()
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

            ShopDashBoard shopDashBoard = new ShopDashBoard();
            shopDashBoard.Show();

        }

        private void btnQR_Click(object sender, RoutedEventArgs e)
        {
            string img = "";
            OpenFileDialog file_select = new OpenFileDialog();
            if (file_select.ShowDialog() == true) {
                img = file_select.FileName;
            }
            using (FirstContext context = new FirstContext())
            {
               

                QRCode temp_qrcode = new QRCode()
                {

                    ImageToByte = File.ReadAllBytes(img),
                    QRData = txtQR.Text

                };
               
                context.QRCodes.Add(temp_qrcode);
                context.SaveChanges();


            }

        }
    }
}
