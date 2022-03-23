using ConsoleAppProject.Helpers;
using ConsoleAppProject.App03;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This app will be able to add students to an array, add a mark for each student,
    /// output marks, output stats, and a grade profile.
    /// </summary>
    public class StudentMarks
    {
        private static StudentMarks marker = new StudentMarks();

        // Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeE = 40;
        public const int LowestGradeD = 45;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public const int MAXN_STUDENTS = 10;

        // Properties
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public Grades[] Grades { get; set; }

        public int[] GradeProfile { get; set; }

        public int Sum { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// Constructor for the class, instantiating the student objects and creating a Students 
        /// Array, Marks Array, GradeProfile Array.
        /// </summary>
        public StudentMarks()
        {
            Students = new string[MAXN_STUDENTS] { "Artemis", "Bilal", "Catalina", "Donovan", "Eve", "Franko",
                "Gale", "Hiro", "Itzel", "Jorge" };
            Marks = new int[MAXN_STUDENTS] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Grades = new Grades[MAXN_STUDENTS] {App03.Grades.F, App03.Grades.F, App03.Grades.F,
                                                      App03.Grades.E, App03.Grades.D, App03.Grades.C,
                                                      App03.Grades.B, App03.Grades.A, App03.Grades.A, App03.Grades.A};
            GradeProfile = new int[5];
        }

        /// <summary>
        /// Method that calls other methods in the class upon a string choice
        /// </summary>
        public void MarkStudents()
        {
            ConsoleHelper.OutputHeading("App 3 - Student Marker");
            Console.WriteLine();
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Grades");
            Console.WriteLine("3. Output Stats");
            Console.WriteLine("4. Output Grade Profile");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.WriteLine("Please select an option > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                marker.InputMarks();
            }
            else if (choice == "2")
            {
                marker.OutputGrades();
            }
            else if (choice == "3")
            {
                marker.OutputStats();
            }
            else if (choice == "4")
            {
                marker.OutputGradeProfile();
            }
            else if (choice == "5")
            {
                System.Environment.Exit(0);
            }
            else Console.WriteLine("Invalid choice, please try again.");
            marker.MarkStudents();
        }

        /// <summary>
        /// Input a mark between 0 and 100 for each student and stores it in the Marks array
        /// </summary>
        public void InputMarks()
        {
            Console.WriteLine("The students are: " + String.Join(", ", Students));
            Console.WriteLine();
            Console.WriteLine("Please enter a mark for each student > ");

            for (int i = 0; i < MAXN_STUDENTS; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($"Please enter mark for {Students[i]} ", 0, 100);
                Grades[i] = ConvertToGrade(Marks[i]);
            }
        }

        /// <summary>
        /// List all the students and displays their assigned mark and grade
        /// </summary>
        public void OutputGrades()
        {
            for (int i = 0; i < MAXN_STUDENTS; i++)
            {
                Console.WriteLine($"{Students[i]} mark = {Marks[i]} grade = {Grades[i]}");
            }
        }

        /// <summary>
        /// Convert a student mark into a grade from F (Fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeE)
            {
                return App03.Grades.F;
            }
            else if (mark >= LowestGradeE && mark < LowestGradeD)
            {
                return App03.Grades.E;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return App03.Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return App03.Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return App03.Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return App03.Grades.A;
            }
            else return App03.Grades.NoGrade;
        }

        /// <summary>
        /// Outputs the minimum, maximum, and mean mark for all the students
        /// </summary>
        public void OutputStats()
        {
            Console.WriteLine();
            Console.WriteLine($"Mean mark = {Mean}");
            Console.WriteLine($"Min mark = {Minimum}");
            Console.WriteLine($"Max mark = {Maximum}");
        }

        /// <summary>
        /// Calculate the mean mark for all the students
        /// </summary>
        public void CalculateStats()
        {
            for (int i = 0; i < MAXN_STUDENTS; i++)
            {
                foreach (int mark in Marks)
                {
                    Sum += mark;
                }
            }

            Mean = Sum / MAXN_STUDENTS;
        }

        /// <summary>
        /// Calculates the minimum and maximum mark for all the students
        /// </summary>
        public void CalculateMinMax()
        {
            Minimum = Marks[0];
            Maximum = Marks[9];
            foreach (int mark in Marks)
            {
                if (mark <= Minimum)
                {
                    Minimum = mark;
                }
                else if (mark >= Maximum)
                {
                    Maximum = mark;
                }
            }
        }

        /// <summary>
        /// Outputs a grade profile for each grade
        /// </summary>
        public void OutputGradeProfile()
        {
            foreach (Grades val in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($"The percentage of students that got {val} is {GradeProfile[(int)val]}%");
            }
        }

        /// <summary>
        /// Calculates a grade profile for each of the grades
        /// </summary>
        public void CalculateGradeProfile()
        {
            foreach (Grades grade in Grades)
            {
                GradeProfile[(int)grade] += 1;
            }

            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = GradeProfile[i] * 100 / MAXN_STUDENTS;
            }
        }
    }
}
