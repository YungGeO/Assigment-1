using System;
using System.Collections.Generic;
#nullable enable
public class Program
{

    // subject  class to save the subject name and grades and be able to call it later when we want to add a subject 
    public class Subject
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Subject(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }
    }
    // student class to save the student name id and subjects and be able to call it later when we want to add a student
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
            Subjects = new List<Subject>(); // empty list to hold subjects
        }

        public void AddSubject(Subject subject) // method to add subject to the student
        {
            Subjects.Add(subject);
        }
        public double CalculateAverageGrade() // method to calculate average grade
        {
            if (Subjects.Count == 0) return 0;

            double average = 0;
            foreach (var subject in Subjects)
            {
                average += subject.Grade;
            }
            return average / Subjects.Count;
        }
        public void printStudentInfo() // method to print student info
        {
            Console.WriteLine($"Student Name: {Name}, ID: {ID}");
            Console.WriteLine("Subjects and Grades:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine($"- {subject.Name}: {subject.Grade}");
            }
            Console.WriteLine($"Average Grade: {CalculateAverageGrade()}");
        }
    }
    static List<Student> students = new List<Student>(); // list to hold all students
    static int nextID = 1;// variable to assign unique IDs to students
    public static void Main()
    {
        //lets make the menu
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Subject");
            Console.WriteLine("3. View Students");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();
            if (choice == null)
            {
                Console.WriteLine("No input received. Please try again.");
                continue;
            }

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddGrade();
                    break;
                case "3":
                    PrintUsersInfo();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid name. Student not added.");
            return;//exit method early if input invalid
        }
        //create new student object with the name it was given and a new unique ID
        Student newStudent = new Student(name, nextID++);
        students.Add(newStudent);
        Console.WriteLine($"Student {name} added with ID {newStudent.ID}.");
    }
    static void AddGrade()
    {
        Console.Write("Enter student ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a numeric value.");
            return;
        }

        Student? student = students.Find(student => student.ID == id);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write("Enter subject name: ");
        string? subjectName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(subjectName))
        {
            Console.WriteLine("Invalid subject name.");
            return;
        }

        Console.Write("Enter grade: ");
        if (!double.TryParse(Console.ReadLine(), out double grade) || grade < 0 || grade > 100) //tries to parse the grade as a double , and checks if its between 0 and 100 with ors 
        {
            Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
            return;
        }

        Subject newSubject = new Subject(subjectName, grade);
        student.AddSubject(newSubject);
        Console.WriteLine($"Added subject {subjectName} with grade {grade} to student {student.Name}.");
    }
    static void PrintUsersInfo()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        foreach (var student in students)
        {
            student.printStudentInfo();
            Console.WriteLine(); // blank line between students
        }
    }
}
