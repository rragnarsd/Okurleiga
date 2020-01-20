using System;
using System.Globalization;
using System.Windows.Data;

namespace OkurleigaHF.Models
{
    public class ZeroToEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = (int)value;

            if (number == 0)
            {
                return "";
            }
            else
            {
                return number.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
