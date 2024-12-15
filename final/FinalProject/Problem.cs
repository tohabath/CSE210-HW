using System.Diagnostics;

public class Problem : GameSettings {
    //ATTR
    private string _Problem;
    private int _Score;
    private double _Answer;
    private bool _Correct;
    private int _Penalty;
    private int _Multiplier;
    private Stopwatch _Stopwatch = new();
    private double _TimeLimit;
    private Random rnd = new();
    //METH
    public Random GetRandom()
    {
        return rnd;
    }
    public int GetScore()
    {
        return _Score;
    }
    public string GetProblem(){
        return _Problem;
    }
    public double GetAnswer(){
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
    public double GetTimeLimit(){
        return _TimeLimit;
    }
    public void SetScore(int score)
    {
        _Score = score;
    }
    public void SetProblem(string problem){
        _Problem = problem;
    }
    public void SetAnswer(double answer){
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
    public void SetTimeLimit(double time){
        _TimeLimit = time;
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
                GetProblemSet().Add($"{i} / {table} = ");
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
    public void CreateProblem(int table)
    {
        if (GetProblem().Contains("x"))
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
                    SetAnswer(Math.Round((double)i / table, 2));
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
    }
    public void HandleProblem(int table, string difficulty)
    {
        if (difficulty == "easy")
            {
                SetTimeLimit(5);
            }
        else if (difficulty == "medium")
        {
            SetTimeLimit(4);
        }
        else if (difficulty == "hard")
        {
            SetTimeLimit(3);
        }
        int problemSelection = GetRandom().Next(1, GetProblemSet().Count);
        SetProblem(GetProblemSet()[problemSelection]);
        CreateProblem(table);
        System.Console.WriteLine(GetProblem());
        GetStopwatch().Start();
        Console.Write("> ");
        double response = double.Parse(Console.ReadLine());
        GetStopwatch().Stop();
        double TimePassed = GetStopwatch().Elapsed.TotalSeconds;
        if (response == GetAnswer())
        {
            SetScore(GetScore() + 5);
            SetCorrect(true);
            if (TimePassed <= GetTimeLimit())
            {
                SetMultiplier(GetRandom().Next(2,5));
                SetScore(GetScore() + 3);
            }
            else if (TimePassed > GetTimeLimit())
            {
                SetMultiplier(0);
            }
        }
        else
        {
            if (GetScore() >= 0)
            {
                SetScore(GetScore() - 3);
            }
            else
            {
                SetScore(0);
            }
            SetCorrect(false);
        }
        GetStopwatch().Reset();
    }
}