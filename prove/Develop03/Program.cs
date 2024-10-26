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
        List<string> theMenu = ["1. Memorize", "2. Reset"];
        string userInput;
        string projectStatus = "yes";
        Random rnd = new Random();
        int randomNumber;
        int maxContent = 0;

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

        foreach (string x in Content.getVolContent())
        {
            maxContent += 1;
        }
        maxContent = maxContent - 1;

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
                randomNumber = rnd.Next(0, maxContent);
                bool containsChar = Content.getVolContent()[randomNumber].Contains("_");
                
                if (containsChar == false) 
                {
                    scriptureClass.RemoveWord(randomNumber);
                }
                else
                {
                    Scripture.DisplayScripture();
                }
            } 
            else if (userInput == "2")
            {
                Content.ResetVolatile();
            } 
            else
            {
                projectStatus = "null";
            }
        }
    }
}