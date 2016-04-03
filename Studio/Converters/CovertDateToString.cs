/**
 * Filename:  CovertDateToString.cs
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
    class CovertDateToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] date = value.ToString().Split(' ');
            return date[0];
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }



    }
}
