// File: Repositories/ICandidateRepository.cs
using BootcampHelper.Models;
using System.Collections.Generic;

namespace BootcampHelper.Repositories
{
    public interface ICandidateRepository
    {
        void AddCandidate(Candidate candidate);
        Candidate GetCandidateById(string id);
        List<Candidate> GetAllCandidates();
    }
}
