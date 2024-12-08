using System.Diagnostics;

public class Problem : GameSettings {
    //ATTR
    private string _Problem;
    private int _Answer;
    private bool _Correct;
    private int _Penalty;
    private int _Multiplier;
    private Stopwatch _Stopwatch = new();
    private TimeSpan _TimeLimit;
    private Random rnd = new();
    //METH
    public Random GetRandom()
    {
        return rnd;
    }
    public string GetProblem(){
        return _Problem;
    }
    public int GetAnswer(){
        return _Answer;
    }
    public bool GetCorrect(){
        return _Correct;
    }
    public int GetPenalty(){
        return _Penalty;
    }
    public int GetMultiplier()
    {
        return _Multiplier;
    }
    public Stopwatch GetStopwatch(){
        return _Stopwatch;
    }
    public TimeSpan GetTimeLimit(){
        return _TimeLimit;
    }
    public void SetProblem(string problem){
        _Problem = problem;
    }
    public void SetAnswer(int answer){
        _Answer = answer;
    }
    public void SetCorrect(bool correct){
        _Correct = correct;
    }
    public void SetPenalty(int penalty){
        _Penalty = penalty;
    }
    public void SetMultiplier(int multiplier)
    {
        _Multiplier = multiplier;
    }
    public void SetTimeLimit(int time){
        _TimeLimit = TimeSpan.FromSeconds(time);
    }
    public void BuildProblemSet(int table, string type)
    {
        if (type == "multiplication")
        {
            for (int i = 1; i < 13; i++)
            {
                GetProblemSet().Add($"{table} x {i} = ");
            }
        }
        else if (type == "division")
        {
            for (int i = 1; i < 13; i++)
            {
                GetProblemSet().Add($"{table} / {i} = ");
            }
        }
        else if (type == "addition")
        {
            for (int i = 1; i < 13; i++)
            {
                GetProblemSet().Add($"{table} + {i} = ");
            }
        }
        else if (type == "subtraction")
        {
            for (int i = 1; i < 13; i++)
            {
                GetProblemSet().Add($"{table} - {i} = ");
            }
        }
    }
    public void HandleProblem(int table)
    {
        int problemSelection = GetRandom().Next(1, GetProblemSet().Count);
        SetProblem(GetProblemSet()[problemSelection]);
        if (GetProblem().Contains("X"))
        {
            for (int i = 1; i < 13; i++)
            {
                if (GetProblem().Contains($"{i}") && GetProblem().Contains($"{table}"))
                {
                    SetAnswer(table * i);
                }
            }
        }
        else if (GetProblem().Contains("/"))
        {
            for (int i = 1; i < 13; i++)
            {
                if (GetProblem().Contains($"{i}") && GetProblem().Contains($"{table}"))
                {
                    SetAnswer(table / i);
                }
            }
        }
        else if (GetProblem().Contains("+"))
        {
            for (int i = 1; i < 13; i++)
            {
                if (GetProblem().Contains($"{i}") && GetProblem().Contains($"{table}"))
                {
                    SetAnswer(table + i);
                }
            }
        }
        else if (GetProblem().Contains("-"))
        {
            for (int i = 1; i < 13; i++)
            {
                if (GetProblem().Contains($"{i}") && GetProblem().Contains($"{table}"))
                {
                    SetAnswer(table - i);
                }
            }
        }
        System.Console.WriteLine(GetProblem());
        GetStopwatch().Start();
        Console.Write("> ");
        int response = int.Parse(Console.ReadLine());
        GetStopwatch().Stop();
        if (response == GetAnswer())
        {
            System.Console.WriteLine("Correct! You deal damage!");
            SetCorrect(true);
            TimeSpan TimePassed = GetStopwatch().Elapsed;
            if (GetDifficulty() == "easy")
            {
                SetTimeLimit(15);
                if (TimePassed <= GetTimeLimit())
                {
                    SetMultiplier(4);
                }
            }
            else if (GetDifficulty() == "medium")
            {
                SetTimeLimit(10);
                if (TimePassed <= GetTimeLimit())
                {
                    SetMultiplier(3);
                }
            }
            else if (GetDifficulty() == "hard")
            {
                SetTimeLimit(5);
                if (TimePassed <= GetTimeLimit())
                {
                    SetMultiplier(2);
                }
            }
        }
        else
        {
            System.Console.WriteLine("Wrong! You take damage!");
            SetCorrect(false);
            TimeSpan TimePassed = GetStopwatch().Elapsed;
            if (GetDifficulty() == "easy")
            {
                SetTimeLimit(15);
                if (TimePassed <= GetTimeLimit())
                {
                    SetMultiplier(4);
                }
            }
            else if (GetDifficulty() == "medium")
            {
                SetTimeLimit(10);
                if (TimePassed <= GetTimeLimit())
                {
                    SetMultiplier(3);
                }
            }
            else if (GetDifficulty() == "hard")
            {
                SetTimeLimit(5);
                if (TimePassed <= GetTimeLimit())
                {
                    SetMultiplier(2);
                }
            }
        }
    }
}