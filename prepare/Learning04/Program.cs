using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Assignment theAssignment = new("FirstName Lastname", "Multiplication");

        System.Console.WriteLine(theAssignment.GetSummary());

        MathAssignment theMathAssignment = new("FirstName LastName", "Fractions", "7.3", "8-19");

        System.Console.WriteLine(theMathAssignment.GetSummary());
        System.Console.WriteLine(theMathAssignment.GetHomeworkList());

        WritingAssignment theWritingAssignment = new("FirstName Lastname", "History", "World War II");

        System.Console.WriteLine(theWritingAssignment.GetSummary());
        System.Console.WriteLine(theWritingAssignment.GetWritingInfo());
        
    }
}