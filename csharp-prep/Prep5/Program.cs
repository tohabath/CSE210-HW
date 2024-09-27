using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string myName = PromptUserName();
        int myNumber = PromptUserNumber();
        int mySquareNumber = SquareNumber(myNumber);
        DisplayResult(mySquareNumber, myName);
    }
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        string MyUsername = "";
        MyUsername = Console.ReadLine();
        return MyUsername;
    }
    static int PromptUserNumber()
    {
        System.Console.Write("Please enter your favorite number: ");
        int MyFavoriteNumberInt;
        string MyFavoriteNumberString = Console.ReadLine();
        MyFavoriteNumberInt = int.Parse(MyFavoriteNumberString);
        return MyFavoriteNumberInt;
    }
    static int SquareNumber(int MyFavoriteNumberInt)
    {
        int numberSquared = MyFavoriteNumberInt * MyFavoriteNumberInt;
        return numberSquared;
    }
    static void DisplayResult(int numberSquared, string MyUsername)
    {
        System.Console.WriteLine($"{MyUsername}, the square of your number is {numberSquared}");
    }
}