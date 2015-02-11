using System;
using System.Globalization;
using Hadron.Shared.Common.Text.Extensions;

namespace Hadron.Shared.Common.Text.Case
{
    public static class CamelBackCaseExtensions
    {
        /// <summary>
        /// Overload which uses the current thread's culture info for conversion
        /// </summary>
        public static string ToCamelBackCase(this string input)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return input.ToCamelBackCase(cultureInfo);
        }

        /// <summary>
        /// Overload which uses the culture info with the specified name
        /// </summary>
        public static string ToCamelBackCase(this string input, string cultureInfoName)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureInfoName);
            return input.ToCamelBackCase(cultureInfo);
        }

        /// <summary>
        /// Uses the specified culture info
        /// </summary>
        public static string ToCamelBackCase(this string input, CultureInfo cultureInfo)
        {
            return input.ToCamelCase(cultureInfo).ReplaceFirst(input[0], Char.ToLower(input[0], cultureInfo));
        }

    }
}
