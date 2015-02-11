using System;
using System.Reflection;

namespace Hadron.Shared.Common.Reflection.Extensions
{
    public static class PropertyExtensions
    {
        /// <summary>
        /// Determines whether the specified <see cref="type"/> has a property with name <see cref="propertyName"/>
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        public static bool PropertyExists(this System.Type type, string propertyName)
        {
            if (propertyName == null ) throw new ArgumentNullException("propertyName", "propertyName cannot be null");

            PropertyInfo property = type.GetProperty(propertyName,
                BindingFlags.NonPublic
                | BindingFlags.Public
                | BindingFlags.Static
                | BindingFlags.Instance);

            if (property == null) return false; 

            MethodInfo getter = property.GetGetMethod(true);

            return getter.IsPublic || getter.IsAssembly || getter.IsFamilyOrAssembly;
        }
    }
}
