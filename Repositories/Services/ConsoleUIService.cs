// File: Services/ConsoleUIService.cs
using BootcampHelper.Core;
using BootcampHelper.Models;
using System;

namespace BootcampHelper.Services
{
    public class ConsoleUIService
    {
        private readonly IBootcampManager _manager;

        public ConsoleUIService(IBootcampManager manager)
        {
            _manager = manager;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Bootcamp Helper!");

            while (true)
            {
                Console.WriteLine("\n1. Register Candidate");
                Console.WriteLine("2. Create Cohort");
                Console.WriteLine("3. Assign Task");
                Console.WriteLine("4. View Cohort Members");
                Console.WriteLine("5. View Cohort Tasks");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterCandidate();
                        break;
                    case "2":
                        CreateCohort();
                        break;
                    case "3":
                        AssignTask();
                        break;
                    case "4":
                        ViewCohortMembers();
                        break;
                    case "5":
                        ViewCohortTasks();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void RegisterCandidate()
        {
            Console.Write("Full Name: ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Phone: ");
            var phone = Console.ReadLine();
            Console.Write("DOB (yyyy-mm-dd): ");
            var dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            var gender = Console.ReadLine();
            Console.Write("Address: ");
            var address = Console.ReadLine();
            Console.Write("Cohort ID: ");
            var cohortId = Console.ReadLine();

            var candidate = new Candidate
            {
                FullName = name,
                Email = email,
                PhoneNumber = phone,
                DateOfBirth = dob,
                Gender = gender,
                Address = address
            };

            _manager.RegisterCandidate(candidate, cohortId);
            Console.WriteLine("Candidate Registered.");
        }

        private void CreateCohort()
        {
            Console.Write("Cohort Name: ");
            var name = Console.ReadLine();
            Console.Write("Start Date (yyyy-mm-dd): ");
            var startDate = DateTime.Parse(Console.ReadLine());

            _manager.CreateCohort(name, startDate);
            Console.WriteLine("Cohort Created.");
        }

        private void AssignTask()
        {
            Console.Write("Task Title: ");
            var title = Console.ReadLine();
            Console.Write("Description: ");
            var description = Console.ReadLine();
            Console.Write("Cohort ID: ");
            var cohortId = Console.ReadLine();

            var task = new DailyTask(title, description, cohortId);
            _manager.AssignTaskToCohort(cohortId, task);
            Console.WriteLine("Task Assigned.");
        }

        private void ViewCohortMembers()
        {
            Console.Write("Cohort ID: ");
            var id = Console.ReadLine();

            var members = _manager.GetCandidatesInCohort(id);
            foreach (var member in members)
                Console.WriteLine(member);
        }

        private void ViewCohortTasks()
        {
            Console.Write("Cohort ID: ");
            var id = Console.ReadLine();

            var tasks = _manager.GetTasksForCohort(id);
            foreach (var task in tasks)
                Console.WriteLine(task);
        }
    }
}
