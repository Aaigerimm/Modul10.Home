using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }
    class Student1 : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student1(string name, string fullName, int[] grades)
        {
            Name = name;
            FullName = fullName;
            Grades = grades;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public double GetAvgGrade()
        {
            if (Grades.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Length;
        }
    }
    internal class StudentProgram
    {
        static void Main()
        {
            int[] grades = { 90, 85, 95, 88, 92 };
            IStudent student = new Student1("Aigerim", "Bolaatbek", grades);

            Console.WriteLine("Name: " + student.GetName());
            Console.WriteLine("Full Name: " + student.GetFullName());
            Console.WriteLine("Average Grade: " + student.GetAvgGrade());

            Console.ReadKey();
        }
    }
}
