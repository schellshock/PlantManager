using System;
using HydroCore;

namespace PlantManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to plant manager.");
            DisplayMenu();
            string line = Console.ReadLine();
            Console.WriteLine("You have picked: {0}", line);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Enter one of the following:");
            Console.WriteLine(" 1.) View All records");
            Console.WriteLine(" 2.) Find a record");
            Console.WriteLine(" 3.) Add Crop");
            Console.WriteLine(" 4.) Add Crop Container");
            Console.WriteLine(" 5.) Remove Crop");
            Console.WriteLine(" 6.) Remove Crop Container");
        }
    }
}