// File: Validation/InputValidator.cs
using BootcampHelper.DTOs;
using BootcampHelper.Utils;
using System;

namespace BootcampHelper.Validation
{
    public static class InputValidator
    {
        public static bool ValidateCandidate(CandidateDTO dto, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dto.FullName))
                error = "Full name is required.";
            else if (!StringUtils.IsValidEmail(dto.Email))
                error = "Invalid email format.";
            else if (!DateUtils.TryParseDate(dto.DateOfBirth, out _))
                error = "Date of Birth must be in YYYY-MM-DD format.";
            else if (string.IsNullOrWhiteSpace(dto.CohortId))
                error = "Cohort ID is required.";

            return string.IsNullOrEmpty(error);
        }

        public static bool ValidateCohort(CohortDTO dto, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dto.Name))
                error = "Cohort name is required.";
            else if (!DateUtils.TryParseDate(dto.StartDate, out _))
                error = "Start date must be a valid date (YYYY-MM-DD).";

            return string.IsNullOrEmpty(error);
        }

        public static bool ValidateTask(TaskAssignmentDTO dto, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dto.Title))
                error = "Task title is required.";
            else if (string.IsNullOrWhiteSpace(dto.CohortId))
                error = "Cohort ID must be provided.";

            return string.IsNullOrEmpty(error);
        }
    }
}
