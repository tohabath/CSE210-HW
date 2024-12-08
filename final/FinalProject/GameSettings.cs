using System.Dynamic;

public class GameSettings {
    //ATTR
    private List<string> _ProblemSet = new();
    private string _Difficulty;
    private string _Type;
    private int _Table;
    //METH
    public List<string> GetProblemSet()
    {
        return _ProblemSet;
    }
    public string GetDifficulty()
    {
        return _Difficulty;
    }
    public string GetProblemType()
    {
        return _Type;
    }
    public int GetTable()
    {
        return _Table;
    }
    public void SetDifficulty(string difficulty)
    {
        _Difficulty = difficulty;
    }
    public void SetProblemType(string problemType)
    {
        _Type = problemType;
    }
    public void SetTable(int table)
    {
        _Table = table;
    }
    public void HandleSettings()
    {
        System.Console.Write("Set difficulty (easy, medium, hard): ");
        SetDifficulty(Console.ReadLine());
        System.Console.Write("Set type (multiplication, division, subtraction, addition): ");
        SetProblemType(Console.ReadLine());
        System.Console.Write("Set table you want to work with (2-12): ");
        SetTable(int.Parse(Console.ReadLine()));
    }
}