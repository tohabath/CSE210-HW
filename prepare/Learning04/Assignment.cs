public class Assignment
{
    //ATTR
    private string _studentName;
    private string _topic;
    //CONST
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    //METH
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}