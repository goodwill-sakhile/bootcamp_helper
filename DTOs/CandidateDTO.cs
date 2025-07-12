// File: DTOs/CandidateDTO.cs
namespace BootcampHelper.DTOs
{
    public class CandidateDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string CohortId { get; set; }

        public override string ToString()
        {
            return $"[CandidateDTO] {FullName} | {Email} | Cohort: {CohortId}";
        }
    }
}
