// File: Repositories/ICohortRepository.cs
using BootcampHelper.Models;
using System.Collections.Generic;

namespace BootcampHelper.Repositories
{
    public interface ICohortRepository
    {
        void AddCohort(Cohort cohort);
        Cohort GetCohortById(string id);
        List<Cohort> GetAllCohorts();
    }
}
