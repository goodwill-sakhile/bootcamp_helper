// File: Validation/SubmissionValidator.cs
using BootcampHelper.DTOs;
using System;

namespace BootcampHelper.Validation
{
    public static class SubmissionValidator
    {
        public static bool ValidateSubmission(SubmissionDTO dto, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dto.CandidateId))
                error = "Candidate ID is required.";
            else if (string.IsNullOrWhiteSpace(dto.TaskTitle))
                error = "Task title is required.";

            return string.IsNullOrEmpty(error);
        }
    }
}
