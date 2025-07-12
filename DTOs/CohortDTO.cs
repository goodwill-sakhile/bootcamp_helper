// File: DTOs/CohortDTO.cs
namespace BootcampHelper.DTOs
{
    public class CohortDTO
    {
        public string Name { get; set; }
        public string StartDate { get; set; }

        public override string ToString()
        {
            return $"[CohortDTO] {Name} starts on {StartDate}";
        }
    }
}
