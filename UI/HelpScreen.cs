// File: UI/HelpScreen.cs
using System;

namespace BootcampHelper.UI
{
    public static class HelpScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("==== HELP & COMMANDS ====\n");
            Console.WriteLine("1 - Register Candidate: Add a new student to a specific cohort");
            Console.WriteLine("2 - Create Cohort: Define a new training batch");
            Console.WriteLine("3 - Assign Task: Set a task to a cohort");
            Console.WriteLine("4 - View Members: See all students in a cohort");
            Console.WriteLine("5 - View Tasks: See all tasks assigned to a cohort");
            Console.WriteLine("6 - Reports: Basic analytics and progress");
            Console.WriteLine("0 - Exit the program");

            Console.ResetColor();
        }
    }
}
