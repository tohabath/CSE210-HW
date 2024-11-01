public class MathAssignment : Assignment
{
    //ATTR
    private string _textbookSection;
    private string _problems;
    //CONST
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //METH
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}"; 
    }
}