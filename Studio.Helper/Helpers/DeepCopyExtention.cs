/**
 * Filename:  DeepCopyExtention.cs
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
/**
 * Filename:  DeepCopyExtention.cs
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

namespace com.boutique.Helper.Helpers
{
    public static class DeepCopyExtention
    {
        /// <summary>
        /// This method return new object with new reference.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ob"></param>
        /// <returns></returns>
        public static T CloneObject<T>(object ob)
        {
            List<PropertyInfo> propertyInfo = ob.GetType().GetRuntimeProperties().ToList();
            var Clone = Activator.CreateInstance<T>();
            foreach (PropertyInfo property in propertyInfo)
            {
                if (property.SetMethod != null)
                property.SetValue(Clone, property.GetValue(ob, null), null);
            }
            return Clone;
        }
        /// <summary>
        /// This method return new list object with new reference.
        /// if object is not list then it will return null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ob"></param>
        /// <returns></returns>
        public static T CloneListObject<T>(T ob)
        {
            if (ob == null)
                return default(T);
            dynamic temp = Activator.CreateInstance<T>();
            dynamic list = (T)ob;
            
            foreach (var item in list)
            {
                List<PropertyInfo> propertyInfo = ((System.Reflection.TypeInfo)(item.GetType())).DeclaredProperties.ToList();
                //item.GetType().GetRuntimeProperties().ToList();
                var Clone = Activator.CreateInstance(item.GetType());
                foreach (PropertyInfo property in propertyInfo)
                {
                    property.SetValue(Clone, property.GetValue(item, null), null);
                }
                temp.Add(Clone);
            }
            return temp;
        }
        /// <summary>
        /// This method append list 2 to list 1 .
        /// if object is not list then it will return null.
        /// Note: It just return shallow copy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ob"></param>
        /// <returns></returns>
        public static void ConcatList<T>(T List1, T List2)
        {
            dynamic list2 = (T)List2;
            dynamic list1 = (T)List1;
            foreach (var item in list2)
            {
                list1.Add(item);
            }
        }
        /// <summary>
        /// Perform a deep Copy of the object, using Json as a serialisation method.
        /// </summary>
        /// <typeparam name="T">The type of object being copied.</typeparam>
        /// <param name="source">The object instance to copy.</param>
        /// <returns>The copied object.</returns>
        public static T CloneJson<T>(this T source)
        {
            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source));
        }
    }
}
