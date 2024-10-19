using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new();
        System.Console.WriteLine(fraction.GetTop());
        System.Console.WriteLine(fraction.GetBottom());
        System.Console.WriteLine(fraction.SetTop(3));
        System.Console.WriteLine(fraction.SetBottom(4));
        System.Console.WriteLine(fraction.GetFractionString());
        System.Console.WriteLine(fraction.GetDecimalValue());
    }
}