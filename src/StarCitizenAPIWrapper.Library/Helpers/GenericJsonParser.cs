using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace StarCitizenAPIWrapper.Library.Helpers
{ 
    /// <summary>
    /// Helper class to parse json objects into specific types.
    /// </summary>
    public static class GenericJsonParser
    {
        /// <summary>
        /// Parses the given json data into a new instance of the given type.
        /// </summary>
        public static T ParseJsonIntoNewInstanceOfGivenType<T>(JToken data, Dictionary<string, Func<JToken, object>> customBehaviour)
        {
            var newInstance = (T) Activator.CreateInstance(typeof(T));

            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                var currentValue = propertyInfo.GetCorrectValueFromProperty(data);

                if(string.IsNullOrEmpty(currentValue?.ToString()))
                    continue;

                propertyInfo.SetValue(newInstance,
                    customBehaviour.ContainsKey(propertyInfo.Name)
                        ? customBehaviour[propertyInfo.Name].Invoke(currentValue)
                        : ParseValueIntoSupportedTypeSafe(currentValue.ToString(), propertyInfo.PropertyType));
            }

            return newInstance;
        }

        /// <summary>
        /// Parses the given value into an object of the given type if the conversion was successful.
        /// Otherwise gives back the value as string.
        /// </summary>
        public static object ParseValueIntoSupportedTypeSafe(string value, Type type, bool parseDateTimeFromTimeStamp = false)
        {
            if (type == typeof(string))
                return value.Trim();

            if (type == typeof(int) && int.TryParse(value, out var intResult))
                return intResult;
            if (type == typeof(double) && double.TryParse(value, out var doubleResult))
                return doubleResult;
            if(type == typeof(char) && char.TryParse(value, out var charResult))
                return charResult;
            if (type == typeof(decimal) && decimal.TryParse(value, out var decimalResult))
                return decimalResult;
            if (type == typeof(long) && long.TryParse(value, out var longResult))
                return longResult;
            if (type == typeof(bool))
                return value == "1";

            if (type == typeof(DateTime))
            {
                if (parseDateTimeFromTimeStamp)
                {
                    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    return epoch.AddSeconds(double.Parse(value));
                }

                if(DateTime.TryParse(value, out var dateResult))
                    return dateResult;
            }
            return Activator.CreateInstance(type);
        }

        /// <summary>
        /// Parses the given value into an object of the given type if the conversion was successful.
        /// Otherwise gives back the value as string.
        /// </summary>
        public static T ParseValueIntoSupportedTypeSafe<T>(string value, bool parseDateTimeFromTimeStamp = false)
        {
            return (T) ParseValueIntoSupportedTypeSafe(value, typeof(T), parseDateTimeFromTimeStamp);
        }
    }
}
