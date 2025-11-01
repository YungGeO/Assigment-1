using System;

public class Program
{
    // defining variables that we will need 
    static string studentName;
    static int studentID;
    static string studentSubject;
    static double studentGrade;
    static double studentAverage;
    //make the method that will print the student
    public void PrintStudentInfo()
    {
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Student ID: " + studentID);
        Console.WriteLine("Student Subject: " + studentSubject);
        Console.WriteLine("Student Grade: " + studentGrade);
        Console.WriteLine("Student Average: " + studentAverage);
    }
    //make the method that will add the student
    public void AddStudent(string name, int id, string subject, double grade)
    {
        studentName = name;
        studentID = id;
        studentSubject = subject;
        studentGrade = grade;
    }
    public static void Main()
    {

    }
}