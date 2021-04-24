using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Wpf13
{
    class ValueConverterOne : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool isenable = true;
            if (string.IsNullOrEmpty(value.ToString()))
            {
                isenable = false;
            }
            else if (value.ToString().Length<3)
            {
                isenable = false;
            }
            return isenable;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
