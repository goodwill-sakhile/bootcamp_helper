// File: Models/Candidate.cs
using System;
using System.Collections.Generic;

namespace BootcampHelper.Models
{
    public class Candidate
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Today.Year - DateOfBirth.Year;
        public string Gender { get; set; }
        public string Address { get; set; }
        public string CohortId { get; set; }

        public List<DailyTask> TaskSubmissions { get; set; }

        public Candidate()
        {
            Id = Guid.NewGuid();
            TaskSubmissions = new List<DailyTask>();
        }

        public void SubmitTask(DailyTask task)
        {
            TaskSubmissions.Add(task);
        }

        public override string ToString()
        {
            return $"{FullName} ({Email}) - Cohort: {CohortId}";
        }
    }
}
