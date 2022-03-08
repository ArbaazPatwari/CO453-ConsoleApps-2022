using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The app converts a height and weight into a BMI index score.
    /// </summary>
    /// <author>
    /// Arbaaz Patwari 7/3/2022
    /// </author>
    public class BMI
    {
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

        public string Age { get; set; }
        public string Convention { get; set; }
        public double WeightValue { get; set; }
        public double HeightValue { get; set; }

        public double BMIValue { get; set; }

        public BMI()
        {
            Convention = METRIC;
            Age = ADULT;
            HeightValue = 0;
            WeightValue = 0;
            BMIValue = 0;
        }

        public void CalculateBMI()
        {
            ConsoleHelper.OutputHeading("App 2 - Body Mass Index Calculator");

            Convention = SelectConvention("Please select either the Imperial or Metric System > ");
            Age = SelectAge("Please select whether you are an adult or child > ");

            Console.WriteLine($"Converting your height and weight to BMI for {Age} in {Convention} units: ");

            HeightValue = InputHeight("Please enter your height > ");
            WeightValue = InputWeight("Please enter your weight > ");

            CalculateIndex();

            OutputBMI();
        }

        private string SelectConvention(string prompt)
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
                    if (selection == 1)
                    {
                        inValid = false;
                    }
                    else if (selection == 2)
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

        private string SelectAge(string prompt)
        { 
        }

        private double InputHeight(string prompt)
        { 
        }

        private double InputWeight(string prompt)
        { 
        }

        public void CalculateIndex()
        { 
        }

        private void OutputBMI()
        { 
        }
    }
}
