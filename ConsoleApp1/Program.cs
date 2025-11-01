using System;

public class Program
{

    public static void Main()
    {
        //lets make the menu
        List<string> tasks = new List<string>();
        bool exit = false;
        while (!exit)
            Console.WriteLine("Menu:");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Add Grade");
        Console.WriteLine("3. View Students");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":

                break;
            case "2":

                break;
            case "3":

                break;
            case "4":
                exit = true;
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}
