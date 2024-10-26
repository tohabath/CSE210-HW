public class Reference
{
    //ATTR
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string reference;
    //CONST
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    //METH
    public string Get_book()
    {
        return _book;
    }
    public int Get_chapter()
    {
        return _chapter;
    }
    public int Get_startVerse()
    {
        return _startVerse;
    }
    public int Get_endVerse()
    {
        return _endVerse;
    }
    public string DisplayReference()
    {
        if (_endVerse != 0)
        {
            reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_startVerse}";
        }
        return reference;
    }
}