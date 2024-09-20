using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input course grade percentage: ");
        string courseGradeInput = Console.ReadLine();
        int courseGradeNumber = int.Parse(courseGradeInput);
        string courseGradeOutput = "";
        if (courseGradeNumber >= 90 )
        {
            courseGradeOutput = "A";
        }
        else if (courseGradeNumber >= 80)
        {
            courseGradeOutput = "B";
        }
        else if (courseGradeNumber >= 70)
        {
            courseGradeOutput = "C";
        }
        else if (courseGradeNumber >= 60)
        {
            courseGradeOutput = "D";
        }
        else
        {
            courseGradeOutput = "F";
        }
        
        Console.WriteLine("");
        Console.WriteLine($"Grade projected: {courseGradeOutput}");
        Console.WriteLine("");
        if (courseGradeNumber >= 70)
        {
            Console.WriteLine("Course: PASSED");
        }
        else
        {
            Console.WriteLine("Course: FAILED");
        }
    }
}