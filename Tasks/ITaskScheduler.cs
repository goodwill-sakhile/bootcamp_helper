// File: Tasks/ITaskScheduler.cs
using BootcampHelper.Models;
using System;

namespace BootcampHelper.Tasks
{
    public interface ITaskScheduler
    {
        void ScheduleTask(DailyTask task, DateTime scheduledTime);
    }
}
