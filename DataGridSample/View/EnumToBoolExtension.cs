﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DataGridSample
{
    [ValueConversion(typeof(bool), typeof(Enum))]
    public class EnumToBoolExtension : MarkupExtension, IValueConverter
    {
        #region IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter.Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)value) == true ? parameter : DependencyProperty.UnsetValue;
        }

        #endregion

        #region MarkupExtension

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        #endregion
    }
}