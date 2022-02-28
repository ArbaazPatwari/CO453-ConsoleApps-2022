using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts a user-input distance measure in one unit (fromUnit)
    /// and this will be calculate and outputted as another user-selected unit (toUnit).
    /// </summary>
    /// <author>
    /// Arbaaz Patwari: 24/2/2022
    /// </author>
    public class DistanceConverter
    {
        public const double CENTIMETRES_IN_FEET = 0.0328084;
        public const double CENTIMETRES_IN_YARDS = 0.0109361;
        public const double CENTIMETRES_IN_METRES = 0.01;
        public const double CENTIMETRES_IN_KILOMETRES = 0.00001;
        public const double CENTIMETRES_IN_MILES = 0.0000062137;
        public const double FEET_IN_YARDS = 0.333333;
        public const double FEET_IN_METRES = 0.3048;
        public const double FEET_IN_KILOMETRES = 0.0003048;
        public const double FEET_IN_MILES = 0.000189394;
        public const double YARDS_IN_METRES = 0.9144;
        public const double YARDS_IN_KILOMETRES = 0.0009144;
        public const double YARDS_IN_MILES = 0.000568182;
        public const double METRES_IN_KILOMETRES = 1000;
        public const double METRES_IN_MILES = 1609;
        public const double KILOMETRES_IN_MILES = 0.621371;

        public const string CENTIMETRES = "Centimetres";
        public const string FEET = "Feet";
        public const string YARDS = "Yards";
        public const string METRES = "Metres";
        public const string KILOMETRES = "Kilometres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// Runs the app and executes specified methods in order
        /// </summary>
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select an initial distance unit > ");
            toUnit = SelectUnit("Please select the final distance unit > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}: ");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Display a menu of distance units then prompts the user to select one and returns it
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            return ExecuteChoice(choice);
        }

        private string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                toUnit = CENTIMETRES;
            }
            else if (choice == "2")
            {
                toUnit = FEET;
            }
            else if (choice == "3")
            {
                toUnit = YARDS;
            }
            else if (choice == "4")
            {
                toUnit = METRES;
            }
            else if (choice == "5")
            {
                toUnit = KILOMETRES;
            }
            else if (choice == "6")
            {
                toUnit = MILES;
            }

            return toUnit;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {CENTIMETRES}");
            Console.WriteLine($" 2. {FEET}");
            Console.WriteLine($" 3. {YARDS}");
            Console.WriteLine($" 3. {METRES}");
            Console.WriteLine($" 3. {KILOMETRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            { 
            
            }
        }

        private void OutputDistance()
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
