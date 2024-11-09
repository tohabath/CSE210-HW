public class Listing : Activity
{
    //ATTR
    private Random _Random = new();
    List<string> _Prompts = new();
    List <string> _ListedItems = new();
    //METH
    public void RunListing()
    {
        int totalTime = Intro("Welcome to the listing activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        System.Console.WriteLine("Get ready...");
        PlayAnimation(5);
        Console.Clear();
        ListingIntro();
        ListItems(totalTime);
        GetName("listing");
        EndMessage();
    }
    public void ListingIntro()
    {
        _Prompts.Add("Who are people that you appreciate?");
        _Prompts.Add("What are personal strengths of yours?");
        _Prompts.Add("Who are people that you have helped this week?");
        _Prompts.Add("When have you felt the Holy Ghost this month?");
        _Prompts.Add("Who are some of your personal heroes?");

        int thePrompt = _Random.Next(_Prompts.Count);
        System.Console.WriteLine("List as many responses you can to the following prompt:");
        System.Console.WriteLine($"--- {_Prompts[thePrompt]} ---");
        System.Console.Write("\nYou may begin in: ");
        DisplayTimer(9);
        _Prompts.Clear();
    }
    public void ListItems(int totalTime)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(totalTime);
        System.Console.WriteLine("");
        while (endTime > currentTime)
        {
            System.Console.Write("> ");
            _ListedItems.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        System.Console.WriteLine($"You listed {_ListedItems.Count} items!");
        Thread.Sleep(5000);
        _ListedItems.Clear();
    }

}