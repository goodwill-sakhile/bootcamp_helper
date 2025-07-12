// File: UI/SubmissionMenu.cs
using System;
using BootcampHelper.Services;
using BootcampHelper.Models;

namespace BootcampHelper.UI
{
    public class SubmissionMenu
    {
        private readonly ConsoleUIService _uiService;

        public SubmissionMenu(ConsoleUIService service)
        {
            _uiService = service;
        }

        public void SubmitTask()
        {
            Console.Write("Candidate ID: ");
            string candidateId = Console.ReadLine();

            Console.Write("Task Title: ");
            string taskTitle = Console.ReadLine();

            var candidate = _uiService.GetManager()
                                      .GetCandidatesInCohort(null)
                                      .Find(c => c.Id.ToString() == candidateId);

            if (candidate == null)
            {
                Console.WriteLine("Candidate not found.");
                return;
            }

            var task = new DailyTask(taskTitle, "Manual Submission", candidate.CohortId)
            {
                IsSubmitted = true
            };

            candidate.SubmitTask(task);
            Console.WriteLine($"Task '{task.Title}' submitted successfully.");
        }
    }
}
