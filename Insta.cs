using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Prog_122_W23_Lecture_13_Images_FilePicker
{
    public class Insta
    {
        BitmapImage _image;
        string _content;

        public Insta(BitmapImage image, string content)
        {
            _image = image;
            _content = content;
        }

        public Insta(string filePath, string content)
        {
            _image = new BitmapImage(new Uri(filePath, UriKind.RelativeOrAbsolute));
            _content = content;

        }

        public BitmapImage Image { get => _image; set => _image = value; }
        public string Content { get => _content; set => _content = value; }

        public FormatConvertedBitmap GreyScale()
        {
            FormatConvertedBitmap newFormatedBitmapSource = new FormatConvertedBitmap();

            // BitmapSource objects like FormatConvertedBitmap can only have their properties
            // changed within a BeginInit/EndInit block.
            newFormatedBitmapSource.BeginInit();

            // Use the BitmapSource object defined above as the source for this new
            // BitmapSource (chain the BitmapSource objects together).
            newFormatedBitmapSource.Source = Image;

            // Set the new format to Gray32Float (grayscale).
            newFormatedBitmapSource.DestinationFormat = PixelFormats.Gray32Float;
            newFormatedBitmapSource.EndInit();

            return newFormatedBitmapSource;
        }
    }
}
