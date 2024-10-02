public class Resume
{
    //Attr
    public string _name;
    public List<Job> _jobs = new List<Job>();
    //Beh
    public void DisplayResume()
    {
        System.Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job job in _jobs) {
            job.DisplayJob();
        }
    }
}