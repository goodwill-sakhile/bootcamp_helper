// File: Core/IBootcampManager.cs
using BootcampHelper.Models;
using System.Collections.Generic;

namespace BootcampHelper.Core
{
    public interface IBootcampManager
    {
        void RegisterCandidate(Candidate candidate, string cohortId);
        void CreateCohort(string name, System.DateTime startDate);
        void AssignTaskToCohort(string cohortId, DailyTask task);
        List<DailyTask> GetTasksForCohort(string cohortId);
        List<Candidate> GetCandidatesInCohort(string cohortId);
    }
}
