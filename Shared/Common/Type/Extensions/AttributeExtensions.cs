using System;
using System.Linq;
using System.Reflection;

namespace Hadron.Shared.Common.Type.Extensions
{
    public static class AttributeExtensions
    {
        /// <summary>
        /// Determines whether the specified <see cref="attributeProvider"/> has at least one <see cref="Attribute"/> 
        /// of type <typeparamref name="TAttribute"/>
        /// </summary>
        /// <typeparam name="TAttribute"/>
        public static bool Any<TAttribute>(this ICustomAttributeProvider attributeProvider)
            where TAttribute : Attribute
        {
            return attributeProvider.FirstOrDefault<TAttribute>() != null;
        }

        /// <summary>
        /// Returns the first custom attribute of specified type <see cref="TAttribute"/> or null
        /// </summary>
        /// <typeparam name="TAttribute"/>
        public static TAttribute FirstOrDefault<TAttribute>(this ICustomAttributeProvider attributeProvider)
            where TAttribute : Attribute
        {
            return attributeProvider.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
        }
    }
}
