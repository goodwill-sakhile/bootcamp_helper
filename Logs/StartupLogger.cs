// File: Logs/StartupLogger.cs
using System;

namespace BootcampHelper.Logs
{
    public static class StartupLogger
    {
        public static void LogBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***************************************");
            Console.WriteLine("*    BOOTCAMP HELPER LOG STARTED     *");
            Console.WriteLine("***************************************");
            Console.ResetColor();

            Logger.Info("System initialized.");
        }

        public static void LogShutdown()
        {
            Logger.Info("System shutting down cleanly.");
            Console.WriteLine("\nLogged exit to file. Goodbye!");
        }
    }
}
