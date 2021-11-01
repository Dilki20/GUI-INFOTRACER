using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
using First.Database;
using First.Model;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
namespace First
{
    /// <summary>
    /// Interaction logic for CreateQR.xaml
    /// </summary>
    public partial class CreateQR : UserControl
    {
        QRCodeEncoder encoder = new QRCodeEncoder();
        Bitmap bitmap;
        SaveFileDialog saveFile = new SaveFileDialog();
        public CreateQR()
        {
            InitializeComponent();
        }
        private void btnCreateQR_Click(object sender, RoutedEventArgs e)
        {
            encoder.QRCodeScale = 8;
            bitmap = encoder.Encode(txtQR.Text);
            imageQR.Source = ImageConverter.ToBitmapImage(bitmap);
           
        }
            private void btnSaveQR_Click(object sender, RoutedEventArgs e)
        {
            saveFile.Filter = "PNG|*.png";
            saveFile.FileName = txtQR.Text;

            if (saveFile.ShowDialog() == true)
            {
                if (bitmap != null)
                {
                    bitmap.Save(String.Concat(saveFile.FileName, ".png"), ImageFormat.Png);
                }

            }
           
        }

 
        private void btnnewAccount_Click(object sender, RoutedEventArgs e)
        {
            PersonalAccount account = new PersonalAccount();
            account.Show();

        }
    }
}
