using System;
using System.Globalization;


namespace KoloryMaui
{
    internal class DoubleToByteString : IValueConverter
    {

        public static string ToByteString(double value)
        {
            return Math.Round(255 * value).ToString();
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


    internal class RGBToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object? parameter, CultureInfo culture)
        {
            if (values.Contains(null)) return Brush.Black;
            double r = (double)values[0];
            double g = (double)values[1];
            double b = (double)values[2];
            return new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}



