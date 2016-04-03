/**
 * Filename:  StringHelper.cs
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
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace com.boutique.Helper.Helpers
{
    public static class StringHelper
    {
        public static int StringOccurrences(string targetString, string serachStringpattern)
        {
            int count = 0;
            int i = 0;
            while ((i = targetString.IndexOf(serachStringpattern, i)) != -1)
            {
                i += serachStringpattern.Length;
                count++;
            }
            return count;
        }

        public static List<string> GetListOfStringBetweenParenthesis(string targetString)
        {
            List<string> value = new List<string>();

            int startIndex = 0;
            while (targetString.IndexOf("(") != -1)
            {
                string stringPart = targetString.Substring(targetString.IndexOf("("), targetString.IndexOf(")")  + 1);               
                value.Add(stringPart);
                startIndex += stringPart.Length;
                targetString = targetString.Substring(startIndex);
            }
            return value;
        }
    }
}
