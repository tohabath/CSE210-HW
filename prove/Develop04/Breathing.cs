public class Breathing : Activity
{
    //ATTR
    private int _BreatheInTime;
    private int _BreatheOutTime;
    //METH
    public void StartBreathing(int totalTime)
    {
        _BreatheInTime = 4;
        _BreatheOutTime = 6;
        while (totalTime > 0)
        {
            System.Console.Write("\n\nBreathe in... ");
            DisplayTimer(_BreatheInTime);
            System.Console.Write("\n\nBreathe out... ");
            DisplayTimer(_BreatheOutTime);
            totalTime = totalTime - (_BreatheInTime + _BreatheOutTime);
        }
    }
    public void StopBreathing()
    {
        GetName("breathing");
        EndMessage();
    }
    public void RunBreathing()
    {
        int totalTime = Intro("Welcome to the breathing activity!\n\nThis activity will help you relax by walking you through breathing in and out slowly.\n\nClear your mind and focus on your breathing.");
        System.Console.WriteLine("Get ready...");
        PlayAnimation(5);
        StartBreathing(totalTime);
        StopBreathing();
    }
}