// File: Repositories/TaskRepository.cs
using BootcampHelper.Models;
using System.Collections.Generic;
using System.Linq;

namespace BootcampHelper.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<DailyTask> _tasks = new();

        public void AssignTaskToCohort(string cohortId, DailyTask task)
        {
            _tasks.Add(task);
        }

        public List<DailyTask> GetTasksByCohort(string cohortId)
        {
            return _tasks.Where(t => t.AssignedToCohortId == cohortId).ToList();
        }
    }
}
