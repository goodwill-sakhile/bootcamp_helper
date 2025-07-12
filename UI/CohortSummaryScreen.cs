// File: UI/CohortSummaryScreen.cs
using BootcampHelper.Services;
using System;
using System.Linq;

namespace BootcampHelper.UI
{
    public class CohortSummaryScreen
    {
        private readonly ConsoleUIService _uiService;

        public CohortSummaryScreen(ConsoleUIService service)
        {
            _uiService = service;
        }

        public void Show(string cohortId)
        {
            var manager = _uiService.GetManager();
            var candidates = manager.GetCandidatesInCohort(cohortId);
            var tasks = manager.GetTasksForCohort(cohortId);

            Console.WriteLine($"\n--- Summary for Cohort: {cohortId} ---");
            Console.WriteLine($"Total Candidates: {candidates.Count}");
            Console.WriteLine($"Total Tasks Assigned: {tasks.Count}");

            int totalSubmissions = candidates.Sum(c => c.TaskSubmissions.Count);
            Console.WriteLine($"Total Task Submissions: {totalSubmissions}");

            double submissionRate = tasks.Count == 0 ? 0 : (double)totalSubmissions / tasks.Count / candidates.Count * 100;
            Console.WriteLine($"Submission Rate: {submissionRate:0.00}%");
        }
    }
}
