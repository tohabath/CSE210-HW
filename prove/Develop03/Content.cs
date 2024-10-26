public class Content
{
    //ATTR
    private static List<string>_content = [];
    private static List<string>_volatileContent = [];
    //CONST
    public Content(string passage)
    {

        foreach (string x in passage.Split(' '))
        {
            _content.Add(x);
            _volatileContent.Add(x);
        }
    }
    //METH
    public List<string> getContent()
    {
        return _content;
    }
    public static List<string> getVolContent()
    {
        return _volatileContent;
    }
    public void DisplayCurrent(string reference)
    {
        System.Console.Write(reference);
        System.Console.Write(" ");
        foreach (string x in _volatileContent)
        {
            System.Console.Write(x);
            System.Console.Write(" ");
        }
        System.Console.Write("\n\n");
    }
    public static void ResetVolatile()
    {
        _volatileContent = _content;
        Scripture.DisplayScripture();
    }
    public static void ChangeVolatile(int randomNumber)
    {
        string word = "";

        foreach (char x in _volatileContent[randomNumber])
        {
            word += "_";
        }
        _volatileContent[randomNumber] = word;
    }
}