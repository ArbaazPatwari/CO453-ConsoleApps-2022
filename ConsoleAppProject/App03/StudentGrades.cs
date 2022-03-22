using ConsoleAppProject.Helpers;
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

        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Mininmum { get; set; }

        public int Maximum { get; set; }

        public StudentMarks()
        {

        }

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

        public void InputMarks()
        {
            Students = new string[] { "Artemis", "Bilal", "Catalina", "Donovan", "Eve", "Franko",
                "Gale", "Hiro", "Itzel", "Jorge" };
            Marks = new int[Students.Length];

            Console.WriteLine("The students are: " + String.Join(", ", Students));
            Console.WriteLine();
            Console.WriteLine("Please enter a mark for each student > ");

            int index = 0;

            foreach (string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name} - Enter mark > ", 0, 100);
                Marks[index] = mark;
            }
        }

        public void OutputGrades()
        {
            for (int index = 0; index < Marks.Length; index++)
            {
                int mark = Marks[index];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($"{Students[index]}  Mark = {Marks[index]}  Grade = {grade}");
            }
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark <= 39)
            {
                return Grades.F;
            }
            else if (mark >= 40 && mark <= 49)
            {
                return Grades.D;
            }
            else if (mark >= 50 && mark <= 59)
            {
                return Grades.C;
            }
            else if (mark >= 60 && mark <= 69)
            {
                return Grades.B;
            }
            else if (mark >= 70 && mark <= 100)
            {
                return Grades.A;
            }
            else return Grades.NoGrade;
        }

        public void OutputStats()
        {
        }

        public void OutputGradeProfile()
        {
        }
    }
}
