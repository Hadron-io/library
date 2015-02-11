using System;
using System.Text;

namespace Hadron.Shared.Common.Text.Tools
{
    public static class Minifier
    {
        /// <summary>
        /// safe for HTML, JS, CSS
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Web(string text)
        {
            if(text == null) throw new ArgumentNullException("text", "text cannot be null");
            char lastAdded = ' ';
            StringBuilder builder = new StringBuilder();
            foreach (char c in text)
            {
                char temp = c;
                if (temp == '\t' || temp == '\r' || temp == '\n') temp = ' ';
                if (temp != ' ' || lastAdded != ' ')
                {
                    builder.Append(temp);
                    lastAdded = temp;
                }
            }

            return builder.ToString();
        }
        
    }
}
