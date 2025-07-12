// File: UI/MainMenu.cs
using System;
using BootcampHelper.Services;
using BootcampHelper.UI;

namespace BootcampHelper.UI
{
    /// <summary>
    /// Main console interface and dispatcher.
    /// </summary>
    public class MainMenu
    {
        private readonly ConsoleUIService _uiService;
        private readonly ReportsMenu _reportsMenu;

        public MainMenu(ConsoleUIService uiService)
        {
            _uiService = uiService;
            _reportsMenu = new ReportsMenu(uiService);
        }

        /// <summary>
        /// Displays the main application menu and routes user choices.
        /// </summary>
        public void Show()
        {
            while (true)
            {
                AsciiArt.DisplayBanner("BOOTCAMP HELPER");
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("1. Register New Candidate");
                Console.WriteLine("2. Create New Cohort");
                Console.WriteLine("3. Assign Daily Task");
                Console.WriteLine("4. View Cohort Members");
                Console.WriteLine("5. View Cohort Tasks");
                Console.WriteLine("6. Reports & Analytics");
                Console.WriteLine("7. Help");
                Console.WriteLine("0. Exit");

                Console.ResetColor();
                Console.Write("\nSelect an option: ");
                string choice = Console.ReadLine();

                Console.Clear();
                NavigationHelper.HandleChoice(choice, _uiService, _reportsMenu);
            }
        }
    }
}
