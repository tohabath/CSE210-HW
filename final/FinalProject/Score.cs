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
    public void HandleScoring(int score, int health)
    {
        if (score + health < 0)
        {
            SetScore(0);
        }
        else
        {
            SetScore(score + health);
        }
        PresentScore();
    }
    public void PresentScore()
    {
        System.Console.WriteLine($"\n\nYOU WIN!\n\nYou scored {GetScore()} points.");
        if(GetScore() > GetHighScore())
        {
            System.Console.WriteLine("A new record!\n");
            SetHighScore(GetScore());
        }
        SetScore(0);
    }
}