/**
 * Filename:  SerializeHelper.cs
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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace com.boutique.Helper.Helpers
{
    /// <summary>
    /// Forms a wrapper class against Newtonsoft.Json.Convert
    /// </summary>
    public static class SerializeHelper
    {
        public static string JSONSerialize(object entity)
        {
            return JsonConvert.SerializeObject(entity);
        } 

        public static string JSONSerialize<T>(T entity)
        {
            return JsonConvert.SerializeObject(entity);
        }

        public static object JsonDeserialize(string jsonContent)
        {
            return JsonConvert.DeserializeObject(jsonContent);
        }

        public static T JsonDeserialize<T>(string jsonContent)
        {
            try
            {
                var res = JToken.Parse(jsonContent);
                return JsonConvert.DeserializeObject<T>(jsonContent);
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }

        public static T Deserialize<T>(string xmlText)
        {
            try
            {
                var stringReader = new System.IO.StringReader(xmlText);
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
            catch
            {
                throw;
            }
        }

    }
}

