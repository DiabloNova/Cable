﻿using System;

namespace Cable
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(" ________  ________  ________  ___       _______      \r\n|\\   ____\\|\\   __  \\|\\   __  \\|\\  \\     |\\  ___ \\     \r\n\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\ /\\ \\  \\    \\ \\   __/|    \r\n \\ \\  \\    \\ \\   __  \\ \\   __  \\ \\  \\    \\ \\  \\_|/__  \r\n  \\ \\  \\____\\ \\  \\ \\  \\ \\  \\|\\  \\ \\  \\____\\ \\  \\_|\\ \\ \r\n   \\ \\_______\\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\_______\\\r\n    \\|_______|\\|__|\\|__|\\|_______|\\|_______|\\|_______|\r\n");
            Console.WriteLine("Active Directory Enumeration and Exploitation tool\n");

            try
            {
                Modules.ArgParse.Parse(args);
            }

            catch (Exception e)
            {
                Console.WriteLine("[!] Exception: " + e.ToString());
            }

        }
    }
}
