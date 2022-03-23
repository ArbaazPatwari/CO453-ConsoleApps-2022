using ConsoleAppProject.Helpers;
using ConsoleAppProject.App03;
using System;

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

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Mininmum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// Constructor for the class, instantiating the student objects and creating a Students 
        /// Array, Marks Array, GradeProfile Array.
        /// </summary>
        public StudentMarks()
        {
            Students = new string[] { "Artemis", "Bilal", "Catalina", "Donovan", "Eve", "Franko",
                "Gale", "Hiro", "Itzel", "Jorge" };
            Marks = new int[Students.Length];
            GradeProfile = new int[(int)Grades.A + 1];
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
            Students = new string[] { "Artemis", "Bilal", "Catalina", "Donovan", "Eve", "Franko",
                "Gale", "Hiro", "Itzel", "Jorge" };
            Marks = new int[Students.Length];
            GradeProfile = new int[(int)Grades.A + 1];

            Console.WriteLine("The students are: " + String.Join(", ", Students));
            Console.WriteLine();
            Console.WriteLine("Please enter a mark for each student > ");
            int index = 0;

            foreach (string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name}: Enter mark > ", 0, 100);
                Marks[index] = mark;
            }
        }

        /// <summary>
        /// List all the students and displays their assigned mark and grade
        /// </summary>
        public void OutputGrades()
        {
            for (int index = 0; index < MAXN_STUDENTS; index++)
            {
                int mark = Marks[index];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($"{Students[index]}  Mark = {Marks[index]}  Grade = {grade}");
            }
        }

        /// <summary>
        /// Convert a student mark into a grade from F (Fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeE)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeE && mark < LowestGradeD)
            {
                return Grades.E;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else return Grades.NoGrade;
        }

        public void OutputStats()
        {
        }

        /// <summary>
        /// Calculate the minimum, maximum and mean mark for all the students
        /// </summary>
        public void CalculateStats()
        { 

        }

        public void OutputGradeProfile()
        { 

        }

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                {
                    GradeProfile[(int)grade]++;
                }
            }
        }
    }
}
