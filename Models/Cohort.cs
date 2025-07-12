// File: Models/Cohort.cs
using System;
using System.Collections.Generic;

namespace BootcampHelper.Models
{
    public class Cohort
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public List<Candidate> Members { get; set; }

        public Cohort()
        {
            Members = new List<Candidate>();
            Id = Guid.NewGuid().ToString();
        }

        public void AddCandidate(Candidate candidate)
        {
            candidate.CohortId = this.Id;
            Members.Add(candidate);
        }

        public override string ToString()
        {
            return $"{Name} ({StartDate.ToShortDateString()}) - {Members.Count} Candidates";
        }
    }
}
