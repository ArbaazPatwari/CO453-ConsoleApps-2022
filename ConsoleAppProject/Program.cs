using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App05;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started. It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Arbaaz Patwari: 27/2/2022
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        private static StudentMarks marker = new StudentMarks();
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022    ");
            Console.WriteLine("        by Arbaaz Patwari                      ");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("App Library - Arbaaz Patwari");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1) App 1 - Distance Converter");
            Console.WriteLine("2) App 2 - Body Mass Index Calculator");
            Console.WriteLine("3) App 3 - Student Marker");
            Console.WriteLine("4) App 4 - Social Network");
            Console.WriteLine("5) App 5 - RPG Game");
            Console.WriteLine("6) Quit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Please enter your choice of app > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                converter.ConvertDistance();
            }
            else if (choice == "2")
            {
                calculator.CalculateBMI();
            }
            else if (choice == "3")
            {
                marker.MarkStudents();
            }
            else if (choice == "4")
            {
            }
            else if (choice == "5")
            {
            }
            else if (choice == "6")
            {
                System.Environment.Exit(0);
            }
            else Console.WriteLine("Invalid choice, please try again.");
            Program.Main(args);
        }
    }
}
