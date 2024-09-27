using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <double> x;
        x = [24, 25, 26] ;

        double thisThing = 10;
        while(thisThing != 0)
        {
            Console.Write("Input: ");
            string input_string = Console.ReadLine();
            thisThing = double.Parse(input_string);
            x.Add(thisThing);
        }
        foreach (int i in x)
        {
        Console.WriteLine(i);
        }
        List <string> y;
        y = ["Why", "must", "you", "do", "this", "to", "me"];
        y.Add("father please");
        List<int>myList = new();
        foreach (string i in y)
        {
            Console.Write(" ");
            Console.Write(i);
        }
        Console.WriteLine("");
        Console.WriteLine("Hello Sandbox World!");
    }
}