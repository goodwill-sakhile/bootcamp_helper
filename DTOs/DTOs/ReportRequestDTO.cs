// File: DTOs/ReportRequestDTO.cs
namespace BootcampHelper.DTOs
{
    public class ReportRequestDTO
    {
        public string CohortId { get; set; }
        public bool IncludeSubmissions { get; set; }
        public bool IncludeCandidateList { get; set; }

        public override string ToString()
        {
            return $"[Report] Cohort: {CohortId}, Subs: {IncludeSubmissions}, List: {IncludeCandidateList}";
        }
    }
}
