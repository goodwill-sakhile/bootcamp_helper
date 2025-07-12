// File: Utils/ConsoleStyler.cs
using System;

namespace BootcampHelper.Utils
{
    public static class ConsoleStyler
    {
        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✔ " + message);
            Console.ResetColor();
        }

        public static void PrintWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚠ " + message);
            Console.ResetColor();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("✖ " + message);
            Console.ResetColor();
        }

        public static void PrintHeader(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== " + message + " ===");
            Console.ResetColor();
        }
    }
}
