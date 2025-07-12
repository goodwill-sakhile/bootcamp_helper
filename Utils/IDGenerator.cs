// File: Utils/IDGenerator.cs
using System;

namespace BootcampHelper.Utils
{
    public static class IDGenerator
    {
        public static string GenerateId(string prefix = "ID")
        {
            return $"{prefix}-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }

        public static string NewCandidateId() => GenerateId("CAND");
        public static string NewTaskId() => GenerateId("TASK");
        public static string NewCohortId() => GenerateId("COH");
    }
}
