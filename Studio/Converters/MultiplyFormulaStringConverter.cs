/**
 * Filename:  MultiplyFormulaStringConverter.cs
 *
 * Copyright 2015 - 2016 Oman Infotech Incorporated
 * All Rights Reserved.
 *
 * NOTICE:  All information contained herein is, and remains
 * the property of Oman Infotech Incorporated and its suppliers,
 * if any. The intellectual and technical concepts contained
 * herein are proprietary to Oman Infotech Incorporated
 * and its suppliers and may be covered by India, U.S. and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 * Dissemination of this information or reproduction of this material
 * is unlawful and strictly forbidden unless prior written permission is obtained
 * from Oman Infotech.
 *
 */


using System;
using System.Globalization;
using System.Windows.Data;

namespace com.boutique.Converters
{
    public class MultiplyFormulaStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double x = 0;
            string strvalue = values[0] as string;
            double.TryParse(strvalue, out x);

            double y = 0;
            strvalue = values[1] as string;
            double.TryParse(strvalue, out y);
     
            var result = string.Format("{0}/-", (x * y).ToString());
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
