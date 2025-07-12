// File: Tests/InputValidatorTests.cs
using NUnit.Framework;
using BootcampHelper.DTOs;
using BootcampHelper.Validation;

namespace BootcampHelper.Tests
{
    [TestFixture]
    public class InputValidatorTests
    {
        [Test]
        public void Candidate_With_Valid_Data_Is_Valid()
        {
            var dto = new CandidateDTO
            {
                FullName = "Jane Smith",
                Email = "jane@example.com",
                Phone = "5555555555",
                DateOfBirth = "1992-01-01",
                Gender = "Female",
                Address = "123 Street",
                CohortId = "COH-1234"
            };

            var isValid = InputValidator.ValidateCandidate(dto, out string error);
            Assert.IsTrue(isValid);
            Assert.IsEmpty(error);
        }

        [Test]
        public void Candidate_With_Missing_Name_Is_Invalid()
        {
            var dto = new CandidateDTO
            {
                FullName = "",
                Email = "invalid@example.com",
                DateOfBirth = "1992-01-01",
                CohortId = "COH-1234"
            };

            var isValid = InputValidator.ValidateCandidate(dto, out string error);
            Assert.IsFalse(isValid);
            Assert.AreEqual("Full name is required.", error);
        }
    }
}
