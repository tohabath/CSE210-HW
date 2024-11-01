public class WritingAssignment : Assignment 
{
    //ATTR
    private string _title;
    //CONST
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    //METH
    public string GetWritingInfo()
    {
        return $"{_title}";
    }
}