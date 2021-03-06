using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts a distance value from one unit to another. It accepts a user-input 
    /// initial unit (fromUnit), final unit (toUnit), and distance value (fromDistance). The
    /// values muse be entered correctly, not negative or containing letters.
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

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        /// <summary>
        /// This is the Constructor and it creates a DistanceConverter object.
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// Runs the app and executes specified methods in order
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading(" App 1 - Distance Converter");

            FromUnit = SelectUnit(" Please select an initial distance unit > ");
            ToUnit = SelectUnit(" Please select the final distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}: ");
            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Handles the selection and return of an input unit
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = InputChoices(prompt);

            string unit = ExecuteChoice(choice);

            Console.WriteLine($"\n You have chosen {unit}");

            return unit;
        }

        /// <summary>
        /// Executes a choice and returns it as a string
        /// </summary>
        private string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                ToUnit = CENTIMETRES;
            }
            else if (choice == "2")
            {
                ToUnit = FEET;
            }
            else if (choice == "3")
            {
                ToUnit = YARDS;
            }
            else if (choice == "4")
            {
                ToUnit = METRES;
            }
            else if (choice == "5")
            {
                ToUnit = KILOMETRES;
            }
            else if (choice == "6")
            {
                ToUnit = MILES;
            }

            return ToUnit;
        }

        /// <summary>
        /// Displays the selection of input choices from the range below and parses a selection
        /// </summary>
        private string InputChoices(string prompt)
        {
            double selection = 1;
            bool inValid;

            Console.WriteLine();
            Console.WriteLine($" 1. {CENTIMETRES}");
            Console.WriteLine($" 2. {FEET}");
            Console.WriteLine($" 3. {YARDS}");
            Console.WriteLine($" 4. {METRES}");
            Console.WriteLine($" 5. {KILOMETRES}");
            Console.WriteLine($" 6. {MILES}");
            Console.WriteLine();

            do
            {
                Console.WriteLine(prompt);
                string choice = Console.ReadLine();

                try
                {
                    selection = Convert.ToDouble(choice);
                    if (selection >= 1 && selection <= 6)
                    {
                        inValid = false;
                    }
                    else
                    {
                        inValid = true;
                        Console.WriteLine(" Invalid selection (out of range), please try again.");
                    }
                }
                catch (Exception)
                {
                    inValid = true;
                    Console.WriteLine(" Invalid selection (incorrect format), please try again.");
                }

            } while (inValid);

            return Convert.ToString(selection);
        }

        /// <summary>
        /// Handles inputting a valid distance unit for conversion
        /// </summary>
        private double InputDistance(string prompt)
        {
            double number = 0;
            bool isValid;
            do
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    if (number > 0)
                    {
                        isValid = false;
                    }
                    else
                    {
                        isValid = true;
                        Console.WriteLine(" Invalid number (negative), please try again.");
                    }
                }
                catch (Exception)
                {
                    isValid = true;
                    Console.WriteLine(" Invalid number (incorrect format), please try again.");
                }

            } while (isValid);

            return Convert.ToDouble(number);
        }

        /// <summary>
        /// Method that calculates each possible distance conversions via multiplying/ dividing constants
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == CENTIMETRES && ToUnit == FEET)
            {
                ToDistance = FromDistance / CENTIMETRES_IN_METRES;
            }
            else if (FromUnit == FEET && ToUnit == CENTIMETRES)
            {
                ToDistance = FromDistance * CENTIMETRES_IN_METRES;
            }
            else if (FromUnit == CENTIMETRES && ToUnit == YARDS)
            {
                ToDistance = FromDistance / CENTIMETRES_IN_YARDS;
            }
            else if (FromUnit == YARDS && ToUnit == CENTIMETRES)
            {
                ToDistance = FromDistance * CENTIMETRES_IN_YARDS;
            }
            else if (FromUnit == CENTIMETRES && ToUnit == METRES)
            {
                ToDistance = FromDistance / CENTIMETRES_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == CENTIMETRES)
            {
                ToDistance = FromDistance * CENTIMETRES_IN_METRES;
            }
            else if (FromUnit == CENTIMETRES && ToUnit == KILOMETRES)
            {
                ToDistance = FromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (FromUnit == CENTIMETRES && ToUnit == MILES)
            {
                ToDistance = FromDistance * CENTIMETRES_IN_KILOMETRES;
            }
            else if (FromUnit == FEET && ToUnit == YARDS)
            {
                ToDistance = FromDistance / FEET_IN_YARDS;
            }
            else if (FromUnit == YARDS && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_YARDS;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == FEET && ToUnit == KILOMETRES)
            {
                ToDistance = FromDistance / FEET_IN_KILOMETRES;
            }
            else if (FromUnit == KILOMETRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_KILOMETRES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == YARDS && ToUnit == METRES)
            {
                ToDistance = FromDistance / YARDS_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == YARDS)
            {
                ToDistance = FromDistance * YARDS_IN_METRES;
            }
            else if (FromUnit == YARDS && ToUnit == KILOMETRES)
            {
                ToDistance = FromDistance / YARDS_IN_KILOMETRES;
            }
            else if (FromUnit == KILOMETRES && ToUnit == YARDS)
            {
                ToDistance = FromDistance * YARDS_IN_KILOMETRES;
            }
            else if (FromUnit == YARDS && ToUnit == MILES)
            {
                ToDistance = FromDistance / YARDS_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == YARDS)
            {
                ToDistance = FromDistance * YARDS_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == KILOMETRES)
            {
                ToDistance = FromDistance / METRES_IN_KILOMETRES;
            }
            else if (FromUnit == KILOMETRES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_KILOMETRES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == KILOMETRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / KILOMETRES_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == KILOMETRES)
            {
                ToDistance = FromDistance * KILOMETRES_IN_MILES;
            }
        }

        /// <summary>
        /// Ending message after calculation has completed
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" \n {FromDistance} {FromUnit} is {ToDistance} {ToUnit}");
        }
    }
}
