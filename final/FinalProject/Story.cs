public class Story : GameSettings {
    //ATTR
    private string _Desc;
    private int _Rounds;
    //METH
    public int GetRounds()
    {
        return _Rounds;
    }
    public void SetRounds(int rounds)
    {
        _Rounds = rounds;
    }
    public void DetermineRounds()
    {
        
    }
    public void GenerateStory()
    {
        Random rnd = new();
        int randomStory = rnd.Next(1,7);

        if (randomStory == 1)
        {

        }
    }
}