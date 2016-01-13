using FYT.DAL;
using System;

namespace FYT.ConsoleApplicationInitializingDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Database...");

            DataContext context = new DataContext();
            context.Database.Initialize(true);

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
