// File: DTOs/TaskAssignmentDTO.cs
namespace BootcampHelper.DTOs
{
    public class TaskAssignmentDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CohortId { get; set; }

        public override string ToString()
        {
            return $"[TaskDTO] {Title} for Cohort {CohortId}";
        }
    }
}
