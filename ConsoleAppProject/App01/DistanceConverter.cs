using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts a value in a certain distance into another one
    /// </summary>
    /// <author>
    /// Arbaaz Patwari: 24/2/2022
    /// </author>
    public class DistanceConverter
    {
        private double feet;
        private double metres;
        private double miles;
        /// <summary>
        /// Runs the app and executes specified methods in order
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet: ");

            miles = InputDistance("Please enter the number of miles > ");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles:");

            feet = InputDistance("Please enter the number of feet > ");

            CalculateMiles();

            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Please enter the number of miles > ");

            CalculateMetres();

            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void CalculateMetres()
        {
            metres = miles * 1609.34;
        }

        private void CalculateMiles()
        {
            miles = feet / 5280;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("  App 1 - Distance Converter    ");
            Console.WriteLine("  Author - Arbaaz Patwari       ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine(prompt);
        }
    }
}
