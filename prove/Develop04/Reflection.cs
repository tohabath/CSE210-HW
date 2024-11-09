using System.Runtime.CompilerServices;

public class Reflection : Activity
{
    //ATTR
    private Random _Random = new();
    private List<string> _Prompts = new();
    private List<string> _Questions = new();
    //METH
    public void RunReflection()
    {
        int totalTime = Intro("Welcome to the reflecting activity!\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        System.Console.WriteLine("Get ready...");
        PlayAnimation(5);
        Console.Clear();
        PromptUser();
        Reflect(totalTime);
        GetName("reflection");
        EndMessage();
    }
    public void PromptUser()
    {
        _Prompts.Add("Think of a time when you stood up for someone else.");
        _Prompts.Add("Think of a time when you did something really difficult.");
        _Prompts.Add("Think of a time when you helped someone in need.");
        _Prompts.Add("Think of a time when you did something truly selfless.");

        int thePrompt = _Random.Next(_Prompts.Count);
        System.Console.WriteLine($"--- {_Prompts[thePrompt]} ---");
        System.Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        _Prompts.Clear();
    }
    public void Reflect(int totalTime)
    {
        _Questions.Add("Why was this experience meaningful to you?");
        _Questions.Add("Have you ever done anything like this before?");
        _Questions.Add("How did you get started?");
        _Questions.Add("How did you feel when it was complete?");
        _Questions.Add("What made this time different than other times when you were not as successful?");
        _Questions.Add("What is your favorite thing about this experience?");
        _Questions.Add("What could you learn from this experience that applies to other situations?");
        _Questions.Add("What did you learn about yourself through this experience?");
        _Questions.Add("How can you keep this experience in mind in the future?");

        int theQuestion;

        System.Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        System.Console.Write("You may begin in: ");
        DisplayTimer(5);
        Console.Clear();
        while (totalTime > 0)
        {
            theQuestion = _Random.Next(_Questions.Count);
            System.Console.WriteLine(_Questions[theQuestion]);
            PlayAnimation(10);
            totalTime = totalTime - 10;
        }
        _Questions.Clear();
    }
}