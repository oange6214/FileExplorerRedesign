using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace FileExplorerRedesign.Converters;

public class DpiAwarePaddingConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length < 2 || !(values[0] is Window window) || !(values[1] is Thickness baseThickness))
            return new Thickness(0);

        var dpi = VisualTreeHelper.GetDpi(window);
        return new Thickness(
            baseThickness.Left / dpi.DpiScaleX,
            baseThickness.Top / dpi.DpiScaleY,
            baseThickness.Right / dpi.DpiScaleX,
            baseThickness.Bottom / dpi.DpiScaleY
        );
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}