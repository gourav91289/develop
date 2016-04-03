/**
 * Filename:  CustomPasswordBox.cs
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
using System.Net;
using System.Text;
using System.Windows.Data;

namespace com.boutique.Converters
{
    class MultBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            StringBuilder source = new StringBuilder();
            int couter = 0;         
            foreach(var val in values)
            {
                couter++;
                source.Append(val.ToString());
                if (couter == 1)
                    source.Append(" (");
                else if (couter == 2)
                    source.Append(")");
            }
            return source.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }


    }
}
