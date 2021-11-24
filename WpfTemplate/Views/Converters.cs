using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;
using WpfTemplate.Models;

namespace WpfTemplate.Views
{
    public class EventColorConverter : IValueConverter
    {

        public Brush NormalColor { get; set; } = Brushes.Black;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is StateModes state)
            {
                switch (state)
                {
                    case StateModes.Info:
                        return Brushes.Green;
                    case StateModes.Warning:
                        return new SolidColorBrush(Color.FromArgb(255, 254, 189, 3));
                    case StateModes.Error:
                        return new SolidColorBrush(Color.FromArgb(255, 199, 67, 67));
                }
            }
            return NormalColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class EventImageConverter : IValueConverter
    {

        public string DefaultImgPath { get; set; } = "/Wpftemplate;component/Images/no-entry-16.png";

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is StateModes state)
            {
                switch (state)
                {
                    case StateModes.Info:
                        return "/Wpftemplate;component/Images/ok-16.png";
                    case StateModes.Warning:
                        return "/Wpftemplate;component/Images/warning-16.png";
                    case StateModes.Error:
                        return "/Wpftemplate;component/Images/no-entry-16.png";
                }
            }
            return DefaultImgPath;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
