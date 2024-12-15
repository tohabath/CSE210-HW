using System.Xml;

public class Story : GameSettings {
    //ATTR
    private int _Rounds;
    private Random rnd = new();
    //METH
    public int GetRounds()
    {
        return _Rounds;
    }
    public Random GetRandom()
    {
        return rnd;
    }
    public void SetRounds(int rounds)
    {
        _Rounds = rounds;
    }
    public void DetermineRounds(string choice)
    {
        if (choice == "easy")
        {
            SetRounds(2);
        }
        else if (choice == "medium")
        {
            SetRounds(3);
        }
        else if (choice == "hard")
        {
            SetRounds(5);
        }
    }
    public void GenerateStory()
    {
        System.Console.WriteLine();
        int randomStory = GetRandom().Next(1,3);
        if (randomStory == 1)
        {
            System.Console.WriteLine("You are skulking around in a treacherous dungeon.");
        }
        else if (randomStory == 2)
        {
            System.Console.WriteLine("You are wandering through an old, abandoned castle.");
        }
        else if (randomStory == 3)
        {
            System.Console.WriteLine("You are making your way up the long, spiraling staircase of a crumbling tower.");
        }
        SetRounds(GetRounds() - 1);
    }
}