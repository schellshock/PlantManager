using System;
using System.Data.SqlTypes;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using HydroCore;

namespace PlantManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to plant manager.");
            GreenHouse tableGreenHouse = new GreenHouse();

            while (true)
            {
                DisplayMenu();
                
                string line = Console.ReadLine();
                
                if (!ValidInput(line))
                {
                    continue;
                }

                ParseInput(line, tableGreenHouse);
                line = null;
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Enter one of the following 0 for Exit:");
            Console.WriteLine(" 1.) View All records");
            Console.WriteLine(" 2.) Find a record");
            Console.WriteLine(" 3.) Add Crop");
            Console.WriteLine(" 4.) Add Crop Container");
            Console.WriteLine(" 5.) Remove Crop");
            Console.WriteLine(" 6.) Remove Crop Container");
            Console.Write("==>");
        }

        private static bool ValidInput(string line)
        {
            bool parsed = Int32.TryParse(line, out int number);

            if (!parsed)
            {
                return false;
            }

            if (number > 6 || number < 0)
            {
                return false;
            }

            return true;
        }

        private static void ParseInput(string line, GreenHouse tableGreenHouse)
        {
            int input = Int32.Parse(line);
            switch (input)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    ViewAllRecords();
                    break;
                case 2:
                    FindRecord();
                    break;
                case 3:
                    AddCrop();
                    break;
                case 4:
                    AddContainer();
                    break;
                case 5:
                    RemoveCrop();
                    break;
                case 6:
                    RemoveContainer();
                    break;
            }
        }

        private static void ViewAllRecords()
        {
            Console.WriteLine("All Records");
        }

        private static void FindRecord()
        {
            Console.WriteLine("Find a record");
        }

        private static void AddCrop()
        {
            Console.WriteLine("Add Crop");
        }

        private static void AddContainer()
        {
            Console.WriteLine("Add Container");
        }

        private static void RemoveCrop()
        {
            Console.WriteLine("Remove Crop");
        }

        private static void RemoveContainer()
        {
            Console.WriteLine("Remove Container");
        }

        private static void PrintCropContainer()
        {
            Console.WriteLine("Print Container");
        }

        private static void PrintCrop()
        {
            Console.WriteLine("Print Crop");
        }
    }
}