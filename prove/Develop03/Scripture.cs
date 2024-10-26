public class Scripture 
{
    //ATTR
    private static string _reference;
    private static string _content;
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
}