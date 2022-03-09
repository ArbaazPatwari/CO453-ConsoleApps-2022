using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The app converts a height and weight into a BMI index score. It accepts 'HeightValue' height
    /// and 'WeightValue' weight to calculate a BMI. The Conventions that can be selected are
    /// 'Metric' and 'Imperial', and this is taken into account while calculating the BMI score.
    /// The app did not meet outstanding requirements and is limited by only accepting one imperial 
    /// value for height/weight rather than two and combining them.
    /// </summary>
    /// <author>
    /// Arbaaz Patwari 7/3/2022
    /// </author>
    public class BMI
    {
        public const double CENTIMETRES_IN_METRES = 100;
        public const double FEET_IN_METRES = 3.28084;
        public const double KILOGRAMS_IN_STONE = 6.35029;

        public const string POUNDS = "Pounds";
        public const string STONE = "Stone";
        public const string KILOGRAMS = "Kilograms";
        public const string CENTIMETRES = "Centimetres";
        public const string INCHES = "Inches";
        public const string FEET = "Feet";

        public const string METRIC = "Metric";
        public const string IMPERIAL = "Imperial";

        public const string ADULT = "Adult";
        public const string CHILD = "Child";

        //public string Age { get; set; }
        public string Convention { get; set; }
        public double WeightValue { get; set; }
        public double HeightValue { get; set; }

        public double BMIValue { get; set; }

        /// <summary>
        /// This is the Constructor and it creates a DistanceConverter object
        /// </summary>
        public BMI()
        {
            Convention = METRIC;
            //Age = ADULT;
            HeightValue = 0;
            WeightValue = 0;
            BMIValue = 0;
        }

        /// <summary>
        /// Runs the app and executes specified methods in order
        /// </summary>
        public void CalculateBMI()
        {
            ConsoleHelper.OutputHeading(" App 2 - Body Mass Index Calculator");

            Convention = SelectConvention(" Please select either the Imperial or Metric System > ");
            //Age = SelectAge("Please select whether you are an adult or child > ");

            HeightValue = InputValue("\n Please enter your exact height in CENTIMETRES/FEET > ");
            WeightValue = InputValue("\n Please enter your exact weight in KILOGRAMS/STONE > ");

            Console.WriteLine($"\n Using {HeightValue} height and {WeightValue} weight to achieve your BMI Score: ");

            CalculateIndex();

            OutputBMIResult();

            OutputMessage();
        }

        /// <summary>
        /// Handles the selection and return of an input convention
        /// </summary>
        private string SelectConvention(string prompt)
        {
            string choice = InputConvention(prompt);

            string convention = ExecuteChoice(choice);

            Console.WriteLine($"Converting your height and weight to BMI in {Convention} units: ");

            return convention;
        }

        /// <summary>
        /// Executes a choice and returns it as a string
        /// </summary>
        private string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                Convention = METRIC;
            }
            else if (choice == "2")
            {
                Convention = IMPERIAL;
            }

            return Convention;
        }

        /// <summary>
        /// Displays the selection of input conventions from the range below and parses a selection
        /// </summary>
        private string InputConvention(string prompt)
        {
            double selection = 1;
            bool inValid;

            Console.WriteLine();
            Console.WriteLine($"1. {METRIC}");
            Console.WriteLine($"2. {IMPERIAL}");
            Console.WriteLine();

            do
            {
                Console.WriteLine(prompt);
                string choice = Console.ReadLine();

                try
                {
                    selection = Convert.ToDouble(choice);
                    if (selection >= 1 && selection <= 2)
                    {
                        inValid = false;
                    }
                    else
                    {
                        inValid = true;
                        Console.WriteLine("Invalid selection (out of range), please try again.");
                    }
                }
                catch (Exception)
                {
                    inValid = true;
                    Console.WriteLine("Invalid selection (incorrect format), please try again.");
                }

            } while (inValid);

            return Convert.ToString(selection);
        }

        //private string SelectAge(string prompt)
        //{
        //    double selection = 1;
        //    bool inValid;

        //    Console.WriteLine();
        //    Console.WriteLine($"1. {ADULT}");
        //    Console.WriteLine($"2. {CHILD}");
        //    Console.WriteLine();

        //    do
        //    {
        //        Console.WriteLine(prompt);
        //        string choice = Console.ReadLine();

        //        try
        //        {
        //            selection = Convert.ToDouble(choice);
        //            if (selection >= 1 && selection <= 2)
        //            {
        //                inValid = false;
        //            }
        //            else
        //            {
        //                inValid = true;
        //                Console.WriteLine("Invalid selection (out of range), please try again.");
        //            }
        //        }
        //        catch (Exception)
        //        { 
        //            inValid = true;
        //            Console.WriteLine("Invalid number (incorrect format), please try again.");
        //        }

        //    } while (inValid);

        //    return Convert.ToString(selection);
        //}

        /// <summary>
        /// Handles the inputting of one valid value for height or weight
        /// </summary>
        private double InputValue(string prompt)
        {
            double number = 0;
            bool inValid;

            do
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    if (number > 0)
                    {
                        inValid = false;
                    }
                    else
                    {
                        inValid = true;
                        Console.WriteLine("Invalid number (negative), please try again.");
                    }
                }
                catch (Exception)
                {
                    inValid = true;
                    Console.WriteLine("Invalid number (incorrect format), please try again.");
                }

            } while (inValid);

            return Convert.ToDouble(number);
        }

        /// <summary>
        /// Method that calculates the BMI score based on input values and using the formula of 
        /// BMI = weight / (height * height)
        /// </summary>
        public void CalculateIndex()
        {
            if (Convention == "Imperial")
            {
                double RootHeight = HeightValue / FEET_IN_METRES;
                double RootWeight = WeightValue * KILOGRAMS_IN_STONE;
                BMIValue = RootWeight / Math.Pow(RootHeight, 2);
            }
            else 
            {
                double RootHeight = HeightValue / CENTIMETRES_IN_METRES;
                BMIValue = WeightValue / Math.Pow(RootHeight, 2);
            }
        }

        /// <summary>
        /// Method that checks the range of the output BMI value, then writes a specific
        /// message to the user including the weight class the score is associated with
        /// </summary>
        private void OutputBMIResult()
        {
            if (BMIValue <= 18.5)
            {
                Console.WriteLine();
                Console.WriteLine($"Your BMI score is: {BMIValue}. This is categorised by the WHO as 'underweight'.");
            }
            else if (BMIValue >= 18.6 && BMIValue <= 24.9)
            {
                Console.WriteLine();
                Console.WriteLine($"Your BMI score is: {BMIValue}. This is categorised by the WHO as 'Normal'.");
            }
            else if (BMIValue >= 25.0 && BMIValue <= 29.9)
            {
                Console.WriteLine();
                Console.WriteLine($"Your BMI score is: {BMIValue}. This is categorised by the WHO as 'Overweight'.");
            }
            else if (BMIValue >= 30 && BMIValue <= 34.9)
            {
                Console.WriteLine();
                Console.WriteLine($"Your BMI score is: {BMIValue}. This is categorised by the WHO as 'Obese Class I'.");
            }
            else if (BMIValue >= 35 && BMIValue <= 39.9)
            {
                Console.WriteLine();
                Console.WriteLine($"Your BMI score is: {BMIValue}. This is categorised by the WHO as 'Obese Class II'.");
            }
            else if (BMIValue >= 40)
            {
                Console.WriteLine();
                Console.WriteLine($"Your BMI score is: {BMIValue}. This is categorised by the WHO as 'Obese Class III'.");
            }
        }

        /// <summary>
        /// Health related message for BAME groups
        /// </summary>
        private void OutputMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Black, Asian, and other minority groups have a higher risk");
            Console.WriteLine("of developing some long tern (chronic) conditions, such as type 2 diabetes");
            Console.WriteLine();
            Console.WriteLine("These adults with a BMI of: ");
            Console.WriteLine("  23 or more are of increased risk");
            Console.WriteLine("  27.5 or more are at high risk");
        }
    }
}
