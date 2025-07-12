// File: App/Bootstrapper.cs
using BootcampHelper.Config;
using BootcampHelper.Logs;
using System;

namespace BootcampHelper.App
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            Console.Title = "Bootcamp Helper";
            SystemPaths.EnsureFolders();
            Logger.Info("Directories initialized.");
            AppConfig.PrintConfig();
        }
    }
}
