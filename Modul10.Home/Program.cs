using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}");
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return FirstName == other.FirstName && LastName == other.LastName;
            }
            return false;
        }
    }

    public class Student : Person
    {
        public List<Teacher> Teachers { get; } = new List<Teacher>();

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public override void Print()
        {
            Console.WriteLine("Student name:{FirstName} {LastName}");
            Console.WriteLine("Teachers : ");
            foreach (var teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }

    public class Teacher : Person
    {
        public List<Student> Students { get; } = new List<Student>();

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            student.AddTeacher(this);
        }

        public override void Print()
        {
            Console.WriteLine("Teacher: {FirstName} {LastName}");
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine("  {student}");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bolatbek", "Aigerim");
            Student student = new Student("Bolatbek", "Aigerim");
            Teacher teacher = new Teacher("Rakhimova", "Ekaterina");
            student.AddTeacher(teacher);
            teacher.AddStudent(student);

            List<Person> people = new List<Person> { person, student, teacher };

            foreach (var person1 in people)
            {
                person.Print();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
