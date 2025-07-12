// File: Utils/StringUtils.cs
using System;
using System.Text.RegularExpressions;

namespace BootcampHelper.Utils
{
    public static class StringUtils
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");
        }

        public static string Truncate(string input, int length)
        {
            return string.IsNullOrWhiteSpace(input) ? "" :
                   input.Length <= length ? input : input.Substring(0, length) + "...";
        }

        public static bool IsOnlyLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z ]+$");
        }
    }
}
