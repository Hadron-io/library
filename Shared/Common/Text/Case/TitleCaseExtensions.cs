using System.Globalization;

namespace Hadron.Shared.Common.Text.Case
{
    public static class TitleCaseExtensions
    {
        /// <summary>
        /// Overload which uses the current thread's culture info for conversion
        /// </summary>
        public static string ToTitleCase(this string input)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return input.ToTitleCase(cultureInfo);
        }

        /// <summary>
        /// Overload which uses the culture info with the specified name
        /// </summary>
        public static string ToTitleCase(this string input, string cultureInfoName)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureInfoName);
            return input.ToTitleCase(cultureInfo);
        }

        /// <summary>
        /// Uses the specified culture info
        /// </summary>
        public static string ToTitleCase(this string input, CultureInfo cultureInfo)
        {
            return cultureInfo.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
