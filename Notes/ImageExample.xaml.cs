using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Prog_122_W23_Lecture_13_Images_FilePicker.Notes
{
    /// <summary>
    /// Interaction logic for ImageExample.xaml
    /// </summary>
    public partial class ImageExample : Window
    {
        public ImageExample()
        {
            InitializeComponent();
            
        }

        private void btnLoadMochi_Click(object sender, RoutedEventArgs e)
        {
        
        }

        //public void FindFile()
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.InitialDirectory = "c:\\";
        //    dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
        //    dlg.RestoreDirectory = true;

        //    if (dlg.ShowDialog() == System.Windows.DialogResult.OK)
        //    {
        //        string selectedFileName = dlg.FileName;
        //        FileNameLabel.Content = selectedFileName;
        //        BitmapImage bitmap = new BitmapImage();
        //        bitmap.BeginInit();
        //        bitmap.UriSource = new Uri(selectedFileName);
        //        bitmap.EndInit();
        //        ImageViewer1.Source = bitmap;
        //    }
        //}

        //public string FilePopUp()
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.InitialDirectory = "c:\\";
        //    dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
        //    dlg.RestoreDirectory = true;

        //    if (dlg.ShowDialog() == System.Windows.DialogResult.OK)
        //    {
        //        string selectedFileName = dlg.FileName;
        //    }
        //}

        //public void GenerateBitMap(string location)
        //{
        //    BitmapImage bitmap = new BitmapImage();
        //    bitmap.BeginInit();
        //    bitmap.UriSource = new Uri(selectedFileName);
        //    bitmap.EndInit();
        //}
    }
}
