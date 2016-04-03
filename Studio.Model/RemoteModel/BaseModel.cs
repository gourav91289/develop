/**
 * Filename:  BaseModel.cs
 *
 * Levels Beyond CONFIDENTIAL
 *
 * Copyright 2003 - 2015 Levels Beyond Incorporated
 * All Rights Reserved.
 *
 * NOTICE:  All information contained herein is, and remains
 * the property of Levels Beyond Incorporated and its suppliers,
 * if any.  The intellectual and technical concepts contained
 * herein are proprietary to Levels Beyond Incorporated
 * and its suppliers and may be covered by U.S. and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 * Dissemination of this information or reproduction of this material
 * is unlawful and strictly forbidden unless prior written permission is obtained
 * from Levels Beyond Incorporated.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.boutique.Model
{
    public class BaseModel : IDataErrorInfo
    {
        string IDataErrorInfo.this[string propertyName] // Part of the IDataErrorInfo Interface
        {
            get { return GetMessage(propertyName); }
        }

        /// <summary>
        /// Validates current instance properties using Data Annotations.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        string GetMessage(string columnName)
        {

            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentException("Invalid property name", columnName);

            string error = string.Empty;
            var value = this.GetType().GetProperty(columnName).GetValue(this, null);
            var results = new List<ValidationResult>(1);

            var context = new ValidationContext(this, null, null) { MemberName = columnName };

            var result = Validator.TryValidateProperty(value, context, results);

            if (!result)
            {
                var validationResult = results.First();
                error = validationResult.ErrorMessage;
            }
            return error;
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
