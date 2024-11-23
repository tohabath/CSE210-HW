public class Checklist : Goal {
    //ATTR
    private int _TimesCompleted;
    private int _TimesToComplete;
    private int _BonusPoints;
    //METH
    public void SetTimesCompleted(int times)
    {
        _TimesCompleted = times;
    }
    public void SetTimesToComplete(int times)
    {
        _TimesToComplete = times;
    }
    public void SetBonusPoint(int points)
    {
        _BonusPoints = points;
    }
    
    public int GetTimesCompleted()
    {
        return _TimesCompleted;
    }
    public int GetTimesToComplete()
    {
        return _TimesToComplete;
    }
    public int GetBonusPoint()
    {
        return _BonusPoints;
    }

    public int AddBonusPoints()
    {
        int TotalPoints = GetPoint() + GetBonusPoint();
        return TotalPoints;
    }

    public override void ConstructGoal()
    {
        System.Console.WriteLine("Write name");
        System.Console.Write("> ");
        SetName(Console.ReadLine());
        System.Console.WriteLine("Write description");
        System.Console.Write("> ");
        SetDesc(Console.ReadLine());
        System.Console.WriteLine("Set times to complete");
        System.Console.Write("> ");
        SetTimesToComplete(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Set points");
        System.Console.Write("> ");
        SetPoint(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Set bonus points");
        System.Console.Write("> ");
        SetBonusPoint(int.Parse(Console.ReadLine()));
        SetDone(false);
    }
    public override void CompleteGoal()
    {
        if (GetDone() is not true)
        {
            SetTimesCompleted(GetTimesCompleted() + 1);
            if (GetTimesCompleted() == GetTimesToComplete())
            {
                System.Console.WriteLine($"Congratulations! You have earned {AddBonusPoints()} points!");
                SetDone(true);
                SetPoint(AddBonusPoints());
            }
            else
            {
                System.Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");
            }
        }
        else
        {
            System.Console.WriteLine("You've already finished that goal!");
        }
        System.Console.WriteLine("To check how many points you've earned, select the “list goals” option!");
    }
    public override void DisplayGoal()
    {
        for(int i = GetTimesToComplete() - GetTimesCompleted(); i < GetTimesToComplete(); i++)
        {
            System.Console.Write("[X] ");
        }
        for(int i = GetTimesToComplete(); i > GetTimesCompleted(); i--)
        {
            System.Console.Write("[ ] ");
        }

        System.Console.Write($"{GetName()} ({GetDesc()})");
    }
    public override string GetStringRep()
    {
        return $"{GetName()}|{GetDesc()}|{GetPoint()}|{GetBonusPoint()}|{GetTimesCompleted()}|{GetTimesToComplete()}|{GetDone()}|Checklist";
    }
    public override void LoadGoal(string name, string desc, int point, int bonus, int completed, int toComplete, bool done)
    {
        SetName(name);
        SetDesc(desc);
        SetPoint(point);
        SetBonusPoint(bonus);
        SetTimesCompleted(completed);
        SetTimesToComplete(toComplete);
        SetDone(done);
    }
}