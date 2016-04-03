/**
 * Filename:  HttpRequestHelper.cs
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

using System.Collections.Generic;
using System.Text;

namespace com.boutique.Helper.Helpers
{
    public static class HttpRequestHelper
    {
        public static string AddQueryStringToURL(string url, Dictionary<string, List<string>> queryString)
        {
            StringBuilder queryStringBuilder = new StringBuilder(url);
            queryStringBuilder.Append("?");
            foreach (var qString in queryString)
            {
                foreach (var qValue in qString.Value)
                {
                    queryStringBuilder.Append(string.Format("{0}={1}", qString.Key, qValue));
                    queryStringBuilder.Append("&");
                }
            }
            return queryStringBuilder.ToString().TrimEnd("&".ToCharArray());
        }
    }
}
