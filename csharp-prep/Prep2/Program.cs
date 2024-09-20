using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input course grade percentage: ");
        string courseGradeInput = Console.ReadLine();
        int number = int.Parse(courseGradeInput);
        string letter = "";
        if (number >= 90 )
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine("");
        Console.WriteLine($"Grade projected: {letter}");
        Console.WriteLine("");
        if (number >= 70)
        {
            Console.WriteLine("Course: PASSED");
        }
        else
        {
            Console.WriteLine("Course: FAILED");
        }
    }
}