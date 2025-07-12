// File: Repositories/ITaskRepository.cs
using BootcampHelper.Models;
using System.Collections.Generic;

namespace BootcampHelper.Repositories
{
    public interface ITaskRepository
    {
        void AssignTaskToCohort(string cohortId, DailyTask task);
        List<DailyTask> GetTasksByCohort(string cohortId);
    }
}
