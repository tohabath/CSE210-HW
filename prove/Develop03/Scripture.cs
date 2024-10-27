public class Scripture 
{
    //ATTR
    private static string _reference;
    private static string _content;
    private Random rnd = new Random();
    private int randomNumber = 0;
    private int maxContent = 0;
    private int maxVolitileContent = 0;
    private bool containsChar;
    //CONST
    public Scripture(string reference, string content)
    {
        _reference = reference;
        _content = content;
    }
    //METH
    public static void DisplayScripture()
    {
        _content = "";
        foreach (string x in Content.getVolContent())
        {
            _content += $"{x} ";
        }
        System.Console.WriteLine($"\n{_reference} {_content}");
    }
    public void RemoveWord(int randomNumber)
    {
        Content.ChangeVolatile(randomNumber);
        DisplayScripture();
    }
    public int randomizeRemove()
    {
        maxContent = 0;
        maxVolitileContent = 0;
        foreach (string x in Content.getVolContent())
        {
            maxContent += 1;
            if (x.Contains("_"))
            {
                maxVolitileContent += 1;
            }
        }
        maxContent = maxContent - 1;
        
        if (maxVolitileContent < maxContent)
        {
            if (maxContent - 1 == maxVolitileContent)
            {
                System.Console.WriteLine("\nWARNING: Reset required. Next attempt will cause a crash!");
            }
            randomNumber = rnd.Next(0, maxContent);

            containsChar = Content.getVolContent()[randomNumber].Contains("_");
            while (containsChar)
            {
                randomNumber = rnd.Next(0, maxContent);
                containsChar = Content.getVolContent()[randomNumber].Contains("_");
            }
        }
        else 
        {
            randomNumber = -1;
        }
        
        return randomNumber;
    }
}