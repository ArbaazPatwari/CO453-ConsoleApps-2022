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
        public const double CENTIMETRES_IN_FEET = 30.48;
        public const double CENTIMETRES_IN_YARDS = 91.44;
        public const double CENTIMETRES_IN_METRES = 100;
        public const double CENTIMETRES_IN_KILOMETRES = 100000;
        public const double CENTIMETRES_IN_MILES = 160934;
        public const double FEET_IN_YARDS = 3;
        public const double FEET_IN_METRES = 3.28084;
        public const double FEET_IN_KILOMETRES = 3280.84;
        public const double FEET_IN_MILES = 5280;
        public const double YARDS_IN_METRES = 1.09361;
        public const double YARDS_IN_KILOMETRES = 1093.61;
        public const double YARDS_IN_MILES = 1760;
        public const double METRES_IN_KILOMETRES = 1000;
        public const double METRES_IN_MILES = 1609.34;
        public const double KILOMETRES_IN_MILES = 1.60934;

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
            OutputHeading();

            fromUnit = SelectUnit(" Please select an initial distance unit > ");
            toUnit = SelectUnit(" Please select the final distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}: ");
            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Display a menu of distance units then prompts the user to select one and returns it
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
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
            Console.WriteLine($" 4. {METRES}");
            Console.WriteLine($" 5. {KILOMETRES}");
            Console.WriteLine($" 6. {MILES}");
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
            if (fromUnit == CENTIMETRES && toUnit == FEET)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == YARDS)
            {
                toDistance = fromDistance / CENTIMETRES_IN_YARDS;
            }
            else if (fromUnit == YARDS && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_YARDS;
            }
            else if (fromUnit == CENTIMETRES && toUnit == METRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == MILES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == FEET && toUnit == YARDS)
            {
                toDistance = fromDistance / FEET_IN_YARDS;
            }
            else if (fromUnit == YARDS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_YARDS;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / FEET_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_KILOMETRES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == YARDS && toUnit == METRES)
            {
                toDistance = fromDistance / YARDS_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == YARDS)
            {
                toDistance = fromDistance * YARDS_IN_METRES;
            }
            else if (fromUnit == YARDS && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / YARDS_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == YARDS)
            {
                toDistance = fromDistance * YARDS_IN_KILOMETRES;
            }
            else if (fromUnit == YARDS && toUnit == MILES)
            {
                toDistance = fromDistance / YARDS_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == YARDS)
            {
                toDistance = fromDistance * YARDS_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == KILOMETRES && toUnit == MILES)
            {
                toDistance = fromDistance / KILOMETRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * KILOMETRES_IN_MILES;
            }
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("  App 1 - Distance Converter    ");
            Console.WriteLine("  Author - Arbaaz Patwari       ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
        }
    }
}
