public abstract class Goal {
    //ATTR
    private bool _Done;
    private string _Name;
    private string _Desc;
    private int _PointValue;
    //METH
    public void SetName(string name)
    {
        _Name = name;
    }
    public void SetDesc(string desc)
    {
        _Desc = desc;
    }
    public void SetPoint(int points)
    {
        _PointValue = points;
    }
    public void SetDone(bool done)
    {
        _Done = done;
    }
    public string GetName()
    {
        return _Name;
    }
    public string GetDesc()
    {
        return _Desc;
    }
    public int GetPoint()
    {
        return _PointValue;
    }
    public bool GetDone()
    {
        return _Done;
    }
    public virtual void ConstructGoal()
    {
        System.Console.WriteLine("Write name");
        System.Console.Write("> ");
        SetName(Console.ReadLine());
        System.Console.WriteLine("Write description");
        System.Console.Write("> ");
        SetDesc(Console.ReadLine());
        System.Console.WriteLine("Set points");
        System.Console.Write("> ");
        SetPoint(int.Parse(Console.ReadLine()));
        SetDone(false);
    }
    public virtual void CompleteGoal()
    {
        if (GetDone() is not true)
        {
            System.Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");
            SetDone(true);
        }
        else
        {
            System.Console.WriteLine("You've already finished that goal!");
        }
        System.Console.WriteLine("To check how many points you've earned, select the “list goals” option!");
    }
    public virtual void DisplayGoal()
    {
        if (GetDone())
        {
            System.Console.Write("[X] ");
        }
        else
        {
            System.Console.Write("[ ] ");
        }
        System.Console.Write($"{GetName()} ({GetDesc()})");
    }
    public virtual void LoadGoal(string name, string desc, int point, int bonus, int completed, int toComplete, bool done)
    {
        SetName(name);
        SetDesc(desc);
        SetPoint(point);
        SetDone(done);
    }
    public abstract string GetStringRep();
}