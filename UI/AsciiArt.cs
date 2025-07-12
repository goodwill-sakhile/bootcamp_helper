// File: UI/AsciiArt.cs
using System;

namespace BootcampHelper.UI
{
    public static class AsciiArt
    {
        public static void DisplayBanner(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("██████╗  ██████╗  ██████╗ ████████╗ ██████╗ █████╗ ███╗   ███╗");
            Console.WriteLine("██╔══██╗██╔═══██╗██╔═══██╗╚══██╔══╝██╔════╝██╔══██╗████╗ ████║");
            Console.WriteLine("██████╔╝██║   ██║██║   ██║   ██║   ██║     ███████║██╔████╔██║");
            Console.WriteLine("██╔═══╝ ██║   ██║██║   ██║   ██║   ██║     ██╔══██║██║╚██╔╝██║");
            Console.WriteLine("██║     ╚██████╔╝╚██████╔╝   ██║   ╚██████╗██║  ██║██║ ╚═╝ ██║");
            Console.WriteLine("╚═╝      ╚═════╝  ╚═════╝    ╚═╝    ╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝");

            Console.WriteLine($"\n==== {title.ToUpper()} ====\n");
            Console.ResetColor();
        }
    }
}
