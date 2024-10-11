public class Journal
{
    // Team program: Jacob, Geoff, Will, Nixon, , 
    //ATTR
    public List<string> _Entries = new();
    public string content;
    public string filename;

    //ATTR PROMPTS
    public List<string> thePrompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"
    };
    public string prompt;
    public Random promptRandomizer = new();
    public int promptNumber;

    //Methods
    public string inputEntry()
    {
        //CONTENT
        Console.Write("\nInput response: ");
        content = Console.ReadLine();
        return content;
    }
    public string displayPrompt()
    {
        //PROMPT
        promptNumber = promptRandomizer.Next(thePrompts.Count);
        prompt = thePrompts[promptNumber];
        System.Console.WriteLine("");
        Console.WriteLine(prompt);
        return prompt;
    }
    public void displayJournal()
    {
        Console.Write(_Entries);
    }
    public void writeEntries()
    {
        System.Console.Write("\nInput filename: ");
        filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string i in _Entries)
            {
                outputFile.WriteLine($"{i}");
            }
        }
        System.Console.WriteLine("\nSaved.\n");
    }
    public void readEntries()
    {
            System.Console.Write("\nInput filename: ");
            filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            _Entries.Clear();
            
            foreach (string line in lines)
            {
                _Entries.Add(line);
            }
            System.Console.WriteLine("\nLoaded.\n");
    }

}