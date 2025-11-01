using System;
using System.Collections.Generic;
public class Program
{

    public static void Main()
    {
        //lets make the menu
        List<string> tasks = new List<string>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Grade");
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
                    Console.WriteLine("choice 1 selected.");
                    break;
                case "2":
                    Console.WriteLine("choice 2 selected.");
                    break;
                case "3":
                    Console.WriteLine("choice 3 selected.");
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
