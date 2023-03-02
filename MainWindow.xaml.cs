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

namespace Prog_122_W23_Lecture_13_Images_FilePicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Insta> myInstas = new List<Insta>();

        public MainWindow()
        {
            InitializeComponent();
            //PreloadListOfPictures();
            //DisplayImage(myInstas[1]);
            //DisplayImage(myInstas[0]);
            AddingAnImageToYourControlAndGoingGrey();

          

        }

        public void AddingAnImageToYourControlAndGoingGrey()
        {
            // Open file diagloug
            OpenFileDialog op = new OpenFileDialog();
            string filePath = "";
            if (op.ShowDialog() == true)
            {
                filePath = op.FileName;
            }
           

            // file path
            //string filePath = @"C:\School\Classes\Programming_122\W_23\In_Class\Prog_122_W23_Lecture_13_Images_FilePicker\bin\Debug\net6.0-windows\Images\evil_mochi.png";
            // Pass into URI
            Uri uri = new Uri(filePath);
            // Pass URI into BitMapImage
            BitmapImage bitmap = new BitmapImage(uri);
            // -> Attach to image.source
            //imgDisplay.Source = bitmap;

            // To Convert To GreyScale
            // Create new FormatConvertBitmap
            FormatConvertedBitmap grey = new FormatConvertedBitmap();
            // Begin Init
            grey.BeginInit();
            // Source = BitMapImage
            grey.Source = bitmap;
            // Destination
            grey.DestinationFormat = PixelFormats.Gray32Float;
            //newFormatedBitmapSource.DestinationFormat = PixelFormats.Gray32Float;
            // End Init
            grey.EndInit();

            // Attach to image source
            imgDisplay.Source = grey;

        }



        public void PreloadListOfPictures()
        {

            // Get image address
            string filePath = @"C:\School\Classes\Programming_122\W_23\In_Class\Prog_122_W23_Lecture_13_Images_FilePicker\bin\Debug\net6.0-windows\Images\evil_mochi.png";

            Insta evilMochi = new Insta(filePath, "Evil Mochi");
            myInstas.Add(evilMochi);

            string filePath2 = @"C:\School\Classes\Programming_122\W_23\In_Class\Prog_122_W23_Lecture_13_Images_FilePicker\bin\Debug\net6.0-windows\Images\Screenshot_20230130_063450.png";

            Insta glorious = new Insta(filePath2, "Glorious");
            myInstas.Add(glorious);

     
        }

        public void DisplayImage(Insta insta)
        {
            imgGlorious.Source = insta.GreyScale();
            lblSecondImage.Content = insta.Content;
        }

        public BitmapImage CreateBitMapImage(string filePath)
        {
            //// Create new URI object
            //Uri uri = new Uri(filePath);
            //// Store in BitMapImage
            //BitmapImage bitmap = new BitmapImage(uri);
            //return bitmap;

            return new BitmapImage(new Uri(filePath));
        }

        public void OpenImageTest()
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.InitialDirectory = "c:\\";
            //dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            //dlg.RestoreDirectory = true;

            //if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string selectedFileName = dlg.FileName;
            //    FileNameLabel.Content = selectedFileName;

            //    // In order to get a bitmap, "image?", start here
            //    BitmapImage bitmap = new BitmapImage();
            //    bitmap.BeginInit();
            //    // Put image location in uri
            //    bitmap.UriSource = new Uri(selectedFileName);
            //    bitmap.EndInit();

            //    // Probably display our image to our image control
            //    imgDisplay.Source = bitmap;
            //}
        }

        public string GetFilePath()
        {
            // Opens a file dialogue to find a path to a file
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                return op.FileName;
            }
            else
            {
                return "";
            }
        }

        private void btnDisplayImage_Click(object sender, RoutedEventArgs e)
        {
            string filePath = GetFilePath();

            if(filePath != "")
            {
                lblPath.Content = filePath;
                imgDisplay.Source = CreateBitMapImage(filePath);
            }
            else
            {
                MessageBox.Show("Please select a valid picture");
            }
            

        }
    }
}
