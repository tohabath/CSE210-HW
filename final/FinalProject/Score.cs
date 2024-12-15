public class Score {
    //ATTR
    private int _Score;
    private int _HighScore;
    //METH
    public int GetScore()
    {
        return _Score;
    }
    public int GetHighScore()
    {
        return _HighScore;
    }
    public void SetScore(int score)
    {
        _Score = score;
    }
    public void SetHighScore(int score)
    {
        _HighScore = score;
    }
    public void HandleScoring(int score, int health, bool status)
    {
        if (score + health < 0)
        {
            SetScore(0);
        }
        else
        {
            SetScore(score + health);
        }
        PresentScore(status);
    }
    public void PresentScore(bool status)
    {
        System.Console.WriteLine();
        if (status)
        {
            System.Console.WriteLine("YOU WIN!");
        }
        else
        {
            System.Console.WriteLine("GAME OVER");
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"You scored {GetScore()} points.");
        if(GetScore() > GetHighScore())
        {
            System.Console.WriteLine("A new record!\n");
            SetHighScore(GetScore());
        }
        SetScore(0);
    }
}