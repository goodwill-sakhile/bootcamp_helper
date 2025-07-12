// File: Logs/Logger.cs
using System;
using System.IO;
using BootcampHelper.Config;

namespace BootcampHelper.Logs
{
    public static class Logger
    {
        private static readonly string LogFile;

        static Logger()
        {
            SystemPaths.EnsureFolders();
            LogFile = Path.Combine(AppConfig.LogDirectory, $"log_{DateTime.Now:yyyyMMdd}.txt");
        }

        public static void Info(string message) => Log("INFO", message);
        public static void Warning(string message) => Log("WARNING", message);
        public static void Error(string message) => Log("ERROR", message);

        private static void Log(string level, string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logLine = $"[{timestamp}] [{level}] {message}";

            // Write to file
            File.AppendAllText(LogFile, logLine + Environment.NewLine);

            // Also print to console
            if (level == "ERROR")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (level == "WARNING")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(logLine);
            Console.ResetColor();
        }
    }
}
