public class Eternal : Goal {
    //ATTR
    private int _Momentum;
    //METH
    public void SetMomentum(int momentum)
    {
        _Momentum = momentum;
    }
    public int GetMomentum()
    {
        return _Momentum;
    }
    public override void CompleteGoal()
    {
        SetMomentum(GetMomentum() + 1);
        System.Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");
        System.Console.WriteLine($"You have completed this goal {GetMomentum()} times!");
        if (GetMomentum() == 5 || GetMomentum() == 10 || GetMomentum() == 25 || GetMomentum() == 50 || GetMomentum() == 75 || GetMomentum() == 100)
        {
            SetPoint(GetPoint() + 10);
            System.Console.WriteLine($"Here, have a few extra (10) points, for your commitment. On the house!");
        }
        System.Console.WriteLine("To check how many points you've earned, select the “list goals” option!");
    }
    public override void DisplayGoal()
    {
        System.Console.Write($"[E] {GetName()} ({GetDesc()})");
    }
    public override string GetStringRep()
    {
        return $"{GetName()}|{GetDesc()}|{GetPoint()}|{GetDone()}|Eternal";
    }
}