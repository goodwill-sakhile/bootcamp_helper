// File: Utils/DateUtils.cs
using System;
using System.Globalization;

namespace BootcampHelper.Utils
{
    public static class DateUtils
    {
        public static bool TryParseDate(string input, out DateTime result)
        {
            return DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }

        public static string Today => DateTime.Now.ToString("yyyy-MM-dd");

        public static string FormatDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static bool IsPast(DateTime date)
        {
            return date < DateTime.Today;
        }

        public static int DaysBetween(DateTime from, DateTime to)
        {
            return (to - from).Days;
        }
    }
}
