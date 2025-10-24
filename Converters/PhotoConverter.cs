using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace PracticalWork12.Converters
{
    internal class PhotoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fileName = value as string;
            string imagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            string defaultImage = Path.Combine(imagesPath, "picture.png");

            string filePath = string.IsNullOrWhiteSpace(fileName)
                ? defaultImage
                : Path.Combine(imagesPath, fileName);

            if (!File.Exists(filePath))
                filePath = defaultImage;

            return new BitmapImage(new Uri(filePath));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
