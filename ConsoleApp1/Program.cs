using System;
using System.Collections.Generic;
public class Program
{

    // ssubject  class to save the subject name and grades and be able to call it later when we want to add a subject 
    public class Subject
    {
        public string Name { get; set; }
        public double Grades { get; set; }

        public Subject(string name, double grade)
        {
            Name = name;
            Grades = grade;
        }
    }

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
                    Console.WriteLine("add student.");
                    break;
                case "2":
                    Console.WriteLine("add grade");
                    break;
                case "3":
                    Console.WriteLine("view students.");
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
