// File: App/DependencyConfig.cs
using BootcampHelper.Core;
using BootcampHelper.Repositories;
using BootcampHelper.Services;

namespace BootcampHelper.App
{
    public static class DependencyConfig
    {
        public static ConsoleUIService CreateUIService()
        {
            var candidateRepo = new CandidateRepository();
            var cohortRepo = new CohortRepository();
            var taskRepo = new TaskRepository();

            var manager = new BootcampManager(candidateRepo, cohortRepo, taskRepo);
            return new ConsoleUIService(manager);
        }
    }
}
