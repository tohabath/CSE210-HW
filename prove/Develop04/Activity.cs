public class Activity
{
    //ATTR
    private string _Name;
    private int _Duration;
    // private string _Description;
    //METH
    public int Intro(string description)
    {
        System.Console.WriteLine(description);
        int totalTime = SetDuration();
        Console.Clear();
        return totalTime;
    }
    public string GetName(string name)
    {
        _Name = name;
        return _Name;
    }
    public int SetDuration()
    {
        System.Console.Write("\nHow long, in seconds (minimum of 10), would you like for your session? ");
        int timer = int.Parse(Console.ReadLine());
        _Duration = timer;
        return _Duration;
    }
    public void DisplayTimer(int timer)
    {
        int timeLeft = timer;
        while (timeLeft > 0)
        {
            System.Console.Write(timeLeft);
            Thread.Sleep(1000);
            timeLeft = timeLeft - 1;
            System.Console.Write("\b \b");
        }
    }
    public void EndMessage()
    {
        Console.Clear();
        System.Console.Write("Well done!\n");
        PlayAnimation(5);
        System.Console.WriteLine($"You have completed {_Duration} seconds of the {_Name} activity.");
        Thread.Sleep(5000);
    }
    public void PlayAnimation(double timer)
    {
        bool animating = true;
        double timePassed = 0;
        int phase = 0;
        System.Console.WriteLine("");
        while (animating)
        {
            if (phase == 0)
            {
                System.Console.Write("_");
                phase += 1;
            }
            else if (phase == 1)
            {
                System.Console.Write("-");
                phase += 1;
            }
            else if (phase == 2)
            {
                System.Console.Write("·");
                phase += 1;
            }
            else if (phase == 3)
            {
                System.Console.Write("-");
                phase += 1;
            }
            else if (phase == 4)
            {
                System.Console.Write("_");
                phase += 1;
            }
            else if (phase == 5)
            {
                System.Console.Write("-");
                phase += 1;
            }
            else if (phase == 6)
            {
                System.Console.Write("·");
                phase += 1;
            }
            else if (phase == 7)
            {
                System.Console.Write("-");
                phase = 0;
            }
            if (timePassed == timer)
            {
                animating = false;
            }
            else
            {
                timePassed += 0.5;
            }
            Thread.Sleep(500);
            System.Console.Write("\b \b");
        }
    }
}
