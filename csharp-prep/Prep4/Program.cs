using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        string numberString = "";
        double numberDouble = -1;
        int numberOfNumbers = 0;
        double sumOfNumbers = 0;
        double largestNumber = -1;
        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numberString != "0")
        {
            Console.Write("Enter number: ");
            numberString = Console.ReadLine();
            numberDouble = double.Parse(numberString);
            if (numberDouble > largestNumber)
            {
                largestNumber = numberDouble;
            }
            sumOfNumbers += numberDouble;
            if (numberDouble != 0)
            {
                numbers.Add(numberDouble);
            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            numberOfNumbers += 1;
        }
        double averageOfNumbers = sumOfNumbers / numberOfNumbers;
        System.Console.WriteLine($"The sum is: {sumOfNumbers}");
        System.Console.WriteLine($"The average is: {averageOfNumbers}");
        System.Console.WriteLine($"The largest number is: {largestNumber}");
    }
}