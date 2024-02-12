using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Practice;
[ValueConversion(typeof(DirectoryItemType), typeof(BitmapImage))]

public class HeaderToImageConverter : IValueConverter
{
    public static HeaderToImageConverter Instance = new HeaderToImageConverter();
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var image = "Images/file1.png";
        switch ((DirectoryItemType)value)
        {
            case DirectoryItemType.drive:
                image = "Images/disk.png";
                break;
            case DirectoryItemType.folder:
                image = "Images/folder1.png";
                break;
        }
        return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}