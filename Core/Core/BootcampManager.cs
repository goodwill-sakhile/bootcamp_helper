// File: Core/BootcampManager.cs
using BootcampHelper.Models;
using BootcampHelper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BootcampHelper.Core
{
    public class BootcampManager : IBootcampManager
    {
        private readonly ICandidateRepository _candidateRepo;
        private readonly ICohortRepository _cohortRepo;
        private readonly ITaskRepository _taskRepo;

        public BootcampManager(ICandidateRepository candidateRepo,
                               ICohortRepository cohortRepo,
                               ITaskRepository taskRepo)
        {
            _candidateRepo = candidateRepo;
            _cohortRepo = cohortRepo;
            _taskRepo = taskRepo;
        }

        public void RegisterCandidate(Candidate candidate, string cohortId)
        {
            var cohort = _cohortRepo.GetCohortById(cohortId);
            if (cohort == null)
                throw new Exception("Cohort not found.");

            cohort.AddCandidate(candidate);
            _candidateRepo.AddCandidate(candidate);
        }

        public void CreateCohort(string name, DateTime startDate)
        {
            _cohortRepo.AddCohort(new Cohort { Name = name, StartDate = startDate });
        }

        public void AssignTaskToCohort(string cohortId, DailyTask task)
        {
            _taskRepo.AssignTaskToCohort(cohortId, task);
        }

        public List<DailyTask> GetTasksForCohort(string cohortId)
        {
            return _taskRepo.GetTasksByCohort(cohortId);
        }

        public List<Candidate> GetCandidatesInCohort(string cohortId)
        {
            return _cohortRepo.GetCohortById(cohortId)?.Members ?? new List<Candidate>();
        }
    }
}
