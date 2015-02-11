using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hadron.Data.Entity.Extensions
{
    public static class QueryableExtensions
    {
        /// <summary>
        /// Attaches specified properties to the <see cref="collection"/> param
        /// </summary>
        /// <typeparam name="T"> is <typeparamref name="T"/></typeparam>
        public static IQueryable<T> Including<T>(this IQueryable<T> collection, params Expression<Func<T, object>>[] includeProperties)
            where T : class
        {
            return includeProperties.Aggregate(collection, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
