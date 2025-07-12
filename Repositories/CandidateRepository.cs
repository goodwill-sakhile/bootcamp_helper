// File: Repositories/CandidateRepository.cs
using BootcampHelper.Models;
using System.Collections.Generic;
using System.Linq;

namespace BootcampHelper.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly List<Candidate> _candidates = new();

        public void AddCandidate(Candidate candidate)
        {
            _candidates.Add(candidate);
        }

        public Candidate GetCandidateById(string id)
        {
            return _candidates.FirstOrDefault(c => c.Id.ToString() == id);
        }

        public List<Candidate> GetAllCandidates()
        {
            return _candidates;
        }
    }
}
