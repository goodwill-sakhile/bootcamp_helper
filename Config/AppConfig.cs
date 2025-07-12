// File: Config/AppConfig.cs
using System;

namespace BootcampHelper.Config
{
    public static class AppConfig
    {
        public static string Environment => "Development";
        public static int MaxCandidatesPerCohort => 50;
        public static string LogDirectory => "./Logs";
        public static string DataDirectory => "./Data";

        public static void PrintConfig()
        {
            Console.WriteLine("=== Current Configuration ===");
            Console.WriteLine($"Environment: {Environment}");
            Console.WriteLine($"Max Cohort Size: {MaxCandidatesPerCohort}");
            Console.WriteLine($"Log Path: {LogDirectory}");
            Console.WriteLine($"Data Path: {DataDirectory}");
        }
    }
}
