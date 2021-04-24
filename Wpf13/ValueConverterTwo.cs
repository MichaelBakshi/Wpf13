using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Wpf13
{
    class ValueConverterTwo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool isenable = false;
            if (string.IsNullOrEmpty(value.ToString()))
            {
                isenable = false;
            }
            else if (value.ToString().Length >0)
            {
                isenable = true;
            }
            return isenable;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
