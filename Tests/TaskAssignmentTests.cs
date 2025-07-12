// File: Tests/TaskAssignmentTests.cs
using NUnit.Framework;
using BootcampHelper.Models;
using System;

namespace BootcampHelper.Tests
{
    [TestFixture]
    public class TaskAssignmentTests
    {
        [Test]
        public void Task_Creation_With_Valid_Data_Succeeds()
        {
            var task = new DailyTask("Git Basics", "Intro to version control", "COH-001");
            Assert.AreEqual("Git Basics", task.Title);
            Assert.AreEqual("COH-001", task.AssignedToCohortId);
            Assert.IsFalse(task.IsSubmitted);
        }

        [Test]
        public void Task_Submission_Changes_Flag()
        {
            var task = new DailyTask("Git Advanced", "Branching", "COH-002");
            task.MarkAsSubmitted();
            Assert.IsTrue(task.IsSubmitted);
        }
    }
}
