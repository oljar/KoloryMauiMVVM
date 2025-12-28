using System;
using System.Globalization;


namespace KoloryMaui
{
    internal class DoubleToByteString : IValueConverter
    {

        public static string ToByteString(double value)
        {
            return Math.Round(255*value).ToString();
        }
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            double dvalue = (double)value;
            return ToByteString(dvalue);
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
           throw new NotImplementedException();
        }
    }
}
