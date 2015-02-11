using System;
using System.Collections.Generic;
using System.Linq;

namespace Hadron.Shared.Common.Collection.Extensions
{
    public static class ReplaceExtensions
    {
        /// <summary>
        /// Replaces the given <see cref="source"/> value with the <see cref="replacement"/> value
        /// </summary>
        /// <typeparam name="T" />
        /// <exception cref="ArgumentNullException"/>
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> collection, T source, T replacement) 
            where T : class
        {
            if(source == null) throw new ArgumentNullException("source", "source cannot be null");
            
            return collection.Except(new[] { source }).Union(new[] { replacement });
        }
    }
}
