public class Entry
{
    //ATTR
    public DateTime currentDateTime = DateTime.Now;
    public string theDate;
    public string theContent;
    public string thePrompt;
    
    //Methods
    public string NameEntry(string thePrompt, string theContent)
    {
        theDate = currentDateTime.ToShortDateString();
        string fullEntry = $"{theDate}\n“{thePrompt}”\nYour response: {theContent}";
        System.Console.WriteLine($"\n{fullEntry}\n");
        return fullEntry;
    }
    public void displayEntry()
    {
        
    }
}