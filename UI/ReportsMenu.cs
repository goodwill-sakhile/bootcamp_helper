// File: UI/ReportsMenu.cs
using BootcampHelper.Services;
using System;
using System.Linq;

namespace BootcampHelper.UI
{
    /// <summary>
    /// Presents analytics and statistics.
    /// </summary>
    public class ReportsMenu
    {
        private readonly ConsoleUIService _uiService;

        public ReportsMenu(ConsoleUIService uiService)
        {
            _uiService = uiService;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==== Reports ====");
            Console.ResetColor();

            Console.Write("Enter Cohort ID: ");
            string cohortId = Console.ReadLine();

            var members = _uiService.GetManager().GetCandidatesInCohort(cohortId);
            var tasks = _uiService.GetManager().GetTasksForCohort(cohortId);

            Console.WriteLine($"\nCohort has {members.Count} candidates");
            Console.WriteLine($"Total tasks assigned: {tasks.Count}");

            var completed = members.SelectMany(m => m.TaskSubmissions)
                                   .Count(t => t.AssignedToCohortId == cohortId);

            Console.WriteLine($"Total tasks submitted: {completed}");
        }
    }
}
