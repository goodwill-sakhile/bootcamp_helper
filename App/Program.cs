// File: App/Program.cs
using System;
using BootcampHelper.Config;
using BootcampHelper.Core;
using BootcampHelper.Repositories;
using BootcampHelper.Services;
using BootcampHelper.UI;
using BootcampHelper.Logs;

namespace BootcampHelper.App
{
    public static class Program
    {
        private static ConsoleUIService _uiService;

        public static void Main(string[] args)
        {
            // Welcome banner and config
            StartupLogger.LogBanner();
            AppConfig.PrintConfig();

            // Initialize repositories
            var cohortRepo = new CohortRepository();
            var candidateRepo = new CandidateRepository();
            var taskRepo = new TaskRepository();

            // Bootcamp manager
            var manager = new BootcampManager(candidateRepo, cohortRepo, taskRepo);
            _uiService = new ConsoleUIService(manager);

            // Start menu
            ShowMainMenu();

            // Log graceful exit
            StartupLogger.LogShutdown();
        }

        private static void ShowMainMenu()
        {
            var mainMenu = new MainMenu(_uiService);
            while (true)
            {
                mainMenu.Render();
                Console.Write("\nSelect an option (q to quit): ");
                string input = Console.ReadLine();
                if (input?.Trim().ToLower() == "q")
                    break;

                mainMenu.HandleInput(input);
            }
        }
    }
}
