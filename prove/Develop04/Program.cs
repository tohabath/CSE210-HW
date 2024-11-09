using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        //ATTR
        bool _Continue = true;
        //CONST
        Activity activity = new();
        Breathing breathing = new();
        Reflection reflection = new();
        Listing listing = new();
        Stretching stretching = new();
        //PROGRAM
        while (_Continue)
        {
            Console.Clear();
            System.Console.Write("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit\nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                breathing.RunBreathing();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                reflection.RunReflection();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                listing.RunListing();
            }
            else if (userInput == "4")
            {
                Console.Clear();
                System.Console.WriteLine("Thank you, come again!");
                _Continue = false;
            }
            else
            {
                Console.Clear();
                stretching.RunStretching();
            }
        }
    }
}