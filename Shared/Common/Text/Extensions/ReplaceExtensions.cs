using System;

namespace Hadron.Shared.Common.Text.Extensions
{
    public static class ReplaceExtensions
    {
        /// <summary>
        /// Replaces the first instance of specified existing character with new specified character starting from position 0
        /// </summary>
        /// <param name="input">The string in which the character will be replaced</param>
        /// <param name="oldChar">The existing character to be replaced</param>
        /// <param name="newChar">The new character to replace the existing character</param>
        /// <returns>A copy of <see cref="input"/> with <see cref="oldChar"/> replaced with <see cref="newChar"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReplaceFirst(this string input, char oldChar, char newChar)
        {
            return input.Replace(oldChar, newChar, 0, 1);
        }

        /// <summary>
        /// Replaces the first instance of <see cref="oldChar"/> with <see cref="newChar"/> 
        /// within the substring specified by the bounds of <see cref="startIndex"/> and <see cref="count"/>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="oldChar"></param>
        /// <param name="newChar"></param>
        /// <param name="startIndex"></param>
        /// <param name="count"></param>
        /// <returns>A copy of <see cref="input"/> with <see cref="oldChar"/> replaced with <see cref="newChar"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when <see cref="oldChar"/> was not found</exception>
        public static string Replace(this string input, char oldChar, char newChar, int startIndex, int count)
        {
            int index = input.IndexOf(oldChar, startIndex, count);
            return input.Replace(index, newChar);

        }

        /// <summary>
        /// Replaces the character at the specified index with the specified new character
        /// </summary>
        /// <param name="input">The string in which the character will be replaced</param>
        /// <param name="index">The index of the character to be replaced</param>
        /// <param name="newChar">The new character that will be inserted at <see cref="index"/></param>
        /// <returns>A copy of <see cref="input"/> with <see cref="newChar"/> set at <see cref="index"/></returns>
        public static string Replace(this string input, int index, char newChar)
        {
            char[] chars = input.ToCharArray();
            chars[index] = newChar;

            return new string(chars);

        }
    }
}
