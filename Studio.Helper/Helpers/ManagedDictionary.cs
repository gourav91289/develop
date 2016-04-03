/**
 * Filename:  ManagedDictionary.cs
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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace com.boutique.Helper.Helpers
{
    public static class ManagedDictionary
    {
        public static Dictionary<string, string> GetProper(this Dictionary<string, object> obj)// where T:class
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (obj == null)
                return dict;
            foreach (var key in obj.Keys)
            {
                var type = obj[key].GetType().Name;
                if (type == "String")
                {
                    dict.Add(key, obj[key].ToString().Trim());
                }
                else if (type == "Boolean")
                {
                    dict.Add(key, obj[key].ToString().Trim());
                }
                else if (type == "DateTime")
                {
                    dict.Add(key, ((DateTime)obj[key]).ToString("yyyy-MM-dd 'at' h:mm:ss tt"));
                }
                else if (type == "JArray")
                {
                    var res = ((Newtonsoft.Json.Linq.JArray)(obj[key]));
                    if (res.HasValues)
                    {
                        List<string> lst = new List<string>();
                        foreach (var r in res)
                        {
                            lst.Add(r.ToString().Trim());
                        }
                        dict.Add(key, string.Join(",", lst));
                    }
                }
                else if (type == "JObject")
                {
                    var res = ((Newtonsoft.Json.Linq.JObject)(obj[key]));
                    if (res.HasValues)
                    {
                        dict.Add(key, Regex.Replace(res.ToString().Replace(Environment.NewLine, "").Replace("\"", "").Replace("{", "").Replace("}",""), @"\s+", ""));
                        //List<string> lst = new List<string>();
                        //foreach (var r in res)
                        //{
                        //    lst.Add(r.ToString().Trim());
                        //}
                        //dict.Add(key, string.Join(",", lst));
                    }
                }
            }
            return dict;
        }

        public static Dictionary<string, string> InsertAt(this Dictionary<string,string> list, int index, KeyValuePair<string,string>element )
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var counter = 0;
            foreach(var i in list)
            {
                if (counter++ == index)
                {
                    dict.Add(element.Key, element.Value);
                }
                dict.Add(i.Key,i.Value);
            }
            return dict;

        }

    }
}
