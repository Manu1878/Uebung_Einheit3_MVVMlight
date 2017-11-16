using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Uebung_Einheit3_MVVMlight.Converters
{
    class BoolToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage meatImage = new BitmapImage(new Uri(@".\images\fleisch.png"));
            BitmapImage veganImage = new BitmapImage(new Uri(@".\images\vegan.png"));

            var temp = (bool)value;
            if (temp) return meatImage;
            return veganImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
