// File: Config/SystemPaths.cs
using System.IO;

namespace BootcampHelper.Config
{
    public static class SystemPaths
    {
        public static string Base => Directory.GetCurrentDirectory();
        public static string Logs => Path.Combine(Base, "Logs");
        public static string Data => Path.Combine(Base, "Data");

        public static void EnsureFolders()
        {
            Directory.CreateDirectory(Logs);
            Directory.CreateDirectory(Data);
        }
    }
}
