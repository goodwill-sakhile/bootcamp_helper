// File: Validation/ReportValidator.cs
using BootcampHelper.DTOs;

namespace BootcampHelper.Validation
{
    public static class ReportValidator
    {
        public static bool ValidateRequest(ReportRequestDTO dto, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dto.CohortId))
                error = "Cohort ID must be specified for reports.";

            return string.IsNullOrEmpty(error);
        }
    }
}
