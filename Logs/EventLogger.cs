// File: Logs/EventLogger.cs
using System;
using System.Collections.Generic;

namespace BootcampHelper.Logs
{
    public static class EventLogger
    {
        private static readonly List<string> _events = new List<string>();

        public static void Record(string message)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            _events.Add($"[{time}] {message}");
        }

        public static void DumpEvents()
        {
            Console.WriteLine("\n=== Event History ===");
            foreach (var e in _events)
                Console.WriteLine(e);
        }

        public static void Clear()
        {
            _events.Clear();
        }
    }
}
