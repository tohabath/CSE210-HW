using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Vars
        // List<Scripture> TheScriptures;
        List<string> theMenu = ["1. Memorize", "2. Reset", "3. Guess"];
        string userInput;
        string projectStatus = "yes";

        string thePassage = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father- and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days- yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";

        string book = "Nephi";
        int chapter = 1;
        int startVerse = 1;
        int endVerse = 0;

        //Classes
        Reference referenceClass = new(book, chapter, startVerse, endVerse);

        string theReference = referenceClass.DisplayReference();
        string theContent = "";

        Content contentClass = new(thePassage);

        Scripture scriptureClass = new(theReference, theContent);

        //Functions

        Scripture.DisplayScripture();

        while (projectStatus == "yes")
        {
            System.Console.WriteLine("");
            foreach (string x in theMenu)
            {
                System.Console.WriteLine(x);
            }
            System.Console.Write("\n> ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                int randomNumber = scriptureClass.randomizeRemove();
                scriptureClass.RemoveWord(randomNumber);
            } 
            else if (userInput == "2")
            {
                Content.ResetVolatile();
            } else if (userInput == "3")
            {
                System.Console.WriteLine("\nTry your hand at reciting the scripture passage by typing it! No cheating!");
                System.Console.Write("\n> ");
                userInput = Console.ReadLine();
                if (userInput == thePassage)
                {
                    System.Console.WriteLine("\n\nWell done! You’ve mastered it!");
                }
                if (thePassage.Contains(userInput))
                {
                    System.Console.WriteLine("\n\nYou’re getting there! Try again!");
                }
                else
                {
                    System.Console.WriteLine("\n\nNot even close. Practice some more!");
                }
            }
            else
            {
                projectStatus = "null";
            }
        }
    }
}