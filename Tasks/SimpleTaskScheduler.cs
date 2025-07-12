// File: Tasks/SimpleTaskScheduler.cs
using BootcampHelper.Models;
using System;

namespace BootcampHelper.Tasks
{
    public class SimpleTaskScheduler : ITaskScheduler
    {
        public void ScheduleTask(DailyTask task, DateTime scheduledTime)
        {
            Console.WriteLine($"[Task Scheduler] '{task.Title}' scheduled for {scheduledTime.ToShortDateString()}");
        }
    }
}
