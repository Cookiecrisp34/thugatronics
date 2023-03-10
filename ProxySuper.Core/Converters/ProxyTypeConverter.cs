using System;
using System.Globalization;
using System.Windows.Data;

namespace ProxySuper.Core.Converters
{
    public class ProxyTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.Equals(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Binding.DoNothing;
            }

            if (!value.Equals(true))
            {
                return Binding.DoNothing;
            }

            return parameter;
        }
    }
}
