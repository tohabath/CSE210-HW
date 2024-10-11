using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // ATTR
        Entry entry = new();
        Journal journal = new();
        string neverDie = "null";
        string userInput;

        // METHODS
        while (neverDie == "null")
        {
            System.Console.Write("MENU\n1. Write a new entry\n2. Display the journal\n3. Save the journal to a file\n4. Load the journal from a file\n5. Exit\n\nInput command: ");

            userInput = Console.ReadLine();

            if (userInput == "1") // Write entry
            {
                string thePrompt = journal.displayPrompt();
                string theContent = journal.inputEntry();
                string theEntry = entry.NameEntry(thePrompt, theContent);
                journal._Entries.Add(theEntry);
            }
            else if (userInput == "2") // Show entries
            {
                foreach (string i in journal._Entries)
                {
                    System.Console.WriteLine($"{i}\n");
                }
            }
            else if (userInput == "3") // Save entries
            {
                journal.writeEntries();
            }
            else if (userInput == "4") // Load entries
            {
                System.Console.Write("\nOverwrite current entries? y/n: ");
                userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    journal.readEntries();
                }
            }
            else if (userInput == "5")
            {
                neverDie = "finished";
            }
            else
            {
                System.Console.WriteLine("\nERROR: Unknown command.\n");
            }

        }
    
    }
}
