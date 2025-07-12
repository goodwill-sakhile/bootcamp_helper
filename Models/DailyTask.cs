// File: Models/DailyTask.cs
using System;

namespace BootcampHelper.Models
{
    public class DailyTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AssignedToCohortId { get; set; }
        public bool IsSubmitted { get; set; }

        public DailyTask(string title, string description, string cohortId)
        {
            Title = title;
            Description = description;
            AssignedDate = DateTime.Now;
            AssignedToCohortId = cohortId;
            IsSubmitted = false;
        }

        public override string ToString()
        {
            return $"{Title} - Assigned: {AssignedDate.ToShortDateString()}";
        }
    }
}
