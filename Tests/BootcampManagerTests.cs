// File: Tests/BootcampManagerTests.cs
using NUnit.Framework;
using BootcampHelper.Core;
using BootcampHelper.Models;
using BootcampHelper.Repositories;
using System;

namespace BootcampHelper.Tests
{
    [TestFixture]
    public class BootcampManagerTests
    {
        private BootcampManager _manager;

        [SetUp]
        public void Setup()
        {
            var candidateRepo = new CandidateRepository();
            var cohortRepo = new CohortRepository();
            var taskRepo = new TaskRepository();

            _manager = new BootcampManager(candidateRepo, cohortRepo, taskRepo);
        }

        [Test]
        public void Can_Create_Cohort()
        {
            _manager.CreateCohort("July Cohort", DateTime.Today);
            var cohorts = _manager.GetAllCohorts();
            Assert.AreEqual(1, cohorts.Count);
            Assert.AreEqual("July Cohort", cohorts[0].Name);
        }

        [Test]
        public void Can_Register_Candidate_To_Cohort()
        {
            _manager.CreateCohort("August Cohort", DateTime.Today);
            var cohortId = _manager.GetAllCohorts()[0].Id;

            var candidate = new Candidate
            {
                FullName = "Test User",
                Email = "test@demo.com",
                PhoneNumber = "1234567890",
                DateOfBirth = new DateTime(2000, 1, 1),
                Gender = "Other",
                Address = "Virtual"
            };

            _manager.RegisterCandidate(candidate, cohortId);

            var members = _manager.GetCandidatesInCohort(cohortId);
            Assert.AreEqual(1, members.Count);
        }
    }
}
