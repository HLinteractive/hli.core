// // // --------------------------------------------------------------------------------------------------------------------
// // // <copyright file="HLI.Core.ObjectExtensions.cs" company="Sogeti Sverige AB">
// // //   Copyright © Sogeti Sverige AB, 2016
// // // </copyright>
// // // --------------------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using Newtonsoft.Json;

namespace HLI.Core.Extensions
{
    /// <summary>
    ///     Custom HLi extensions to <see cref="object" />
    /// </summary>
    public static class ObjectExtensions
    {
        #region Static Fields

        /// <summary>
        ///     Default settings for JSON serialization
        /// </summary>
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
                                                                                    {
                                                                                        NullValueHandling = NullValueHandling.Ignore,
                                                                                        MissingMemberHandling = MissingMemberHandling.Ignore,
                                                                                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                                                                        DateTimeZoneHandling = DateTimeZoneHandling.Local,
                                                                                        DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                                                                                    };

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Creates a copy of an object.
        ///     If the object has references to other objects, the entire object graph will be copied.
        /// </summary>
        /// <param name="obj">The object to be copied. The object must be decorated with [DataContract].</param>
        /// <returns>A copy of the object.</returns>
        public static object DeepClone(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            // Create a deep close by serializing and deserializing with JSON
            var serialized = JsonConvert.SerializeObject(obj, JsonSerializerSettings);
            var deserialized = JsonConvert.DeserializeObject(serialized, JsonSerializerSettings);

            return deserialized;
        }

        /// <summary>
        ///     Get the value of specified property
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="propertyName">Name of property</param>
        /// <returns>Value of <see cref="propertyName" /></returns>
        public static object GetValueForProperty(this object obj, string propertyName)
        {
            var objectType = obj.GetType();

            // Get field
            var displayType =
                objectType.GetRuntimeProperties()
                    .FirstOrDefault(info => string.Equals(info.Name, propertyName, StringComparison.CurrentCultureIgnoreCase));

            // Get value
            return displayType.GetValue(obj);
        }

        /// <summary>
        ///     Get the value of specified property
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="propertyName">Property lambda</param>
        /// <returns>Value of <see cref="propertyName" /></returns>
        public static object GetValueForProperty<TProperty>(this object obj, Expression<Func<TProperty>> propertyName)
        {
            return GetValueForProperty(obj, propertyName.ToPropertyName());
        }

        /// <summary>
        ///     Converts the stream to a byte array
        /// </summary>
        public static byte[] StreamToByteArray(this Stream input)
        {
            input.Seek(0, SeekOrigin.Begin);
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }

        #endregion
    }
}