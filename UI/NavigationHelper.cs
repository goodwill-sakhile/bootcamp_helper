// File: UI/NavigationHelper.cs
using BootcampHelper.Services;
using System;

namespace BootcampHelper.UI
{
    public static class NavigationHelper
    {
        public static void HandleChoice(string input, ConsoleUIService service, ReportsMenu reportsMenu)
        {
            switch (input)
            {
                case "1":
                    service.RegisterCandidate();
                    break;
                case "2":
                    service.CreateCohort();
                    break;
                case "3":
                    service.AssignTask();
                    break;
                case "4":
                    service.ViewCohortMembers();
                    break;
                case "5":
                    service.ViewCohortTasks();
                    break;
                case "6":
                    reportsMenu.Show();
                    break;
                case "7":
                    HelpScreen.Show();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
