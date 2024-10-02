public class Job
{
    //Attr
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    //Beh
    public void DisplayJob()
    {
        System.Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}