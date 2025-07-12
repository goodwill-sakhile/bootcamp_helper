// File: DTOs/SubmissionDTO.cs
namespace BootcampHelper.DTOs
{
    public class SubmissionDTO
    {
        public string CandidateId { get; set; }
        public string TaskTitle { get; set; }

        public override string ToString()
        {
            return $"[Submission] Candidate {CandidateId} → {TaskTitle}";
        }
    }
}
