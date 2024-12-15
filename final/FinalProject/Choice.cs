using System.Numerics;
using System.Runtime.InteropServices;

public class Choice {
    //ATTR
    private Random _Random = new();
    private List<string> _Prompts = new(["You spy a door with strange runes on one of the walls. Will you open it?", "You see an item on a pedistal under a shaft of light. Will you take it?", "A hooded stranger offers you a syringe. Will you inject it?", "You find a chest sitting in a corner. Will you open it?", "You spy an abandoned potion, lying next to a dry cauldron. Will you drink it?"]);
    //METH
    public Random GetRandom()
    {
        return _Random;
    }
    public List<string> GetPrompts()
    {
        return _Prompts;
    }
    public bool HandleChoice(string difficulty)
    {
        bool punishment = false;
        int trialScore = 30;
        int inputScore = 0;
        int randomPrompt = GetRandom().Next(0, GetPrompts().Count);
        int randomNumber = GetRandom().Next(1, 10);
        string prompt = GetPrompts()[randomPrompt];
        Console.Write(prompt);
        Console.Write(" (y/n): ");
        string playerInput = Console.ReadLine();
        if (playerInput == "y")
        {
            inputScore = GetRandom().Next(1, 3);
        }
        else
        {
            inputScore = GetRandom().Next(4, 6);
        }
        int totalScore = randomPrompt + inputScore + randomNumber;
        if (difficulty == "easy")
        {
            trialScore = 20;
        }
        else if (difficulty == "medium")
        {
            trialScore = 15;
        }
        else if (difficulty == "hard")
        {
            trialScore = 10;
        }
        if (totalScore >= trialScore)
        {
            punishment = true;
            System.Console.WriteLine("Your actions prove foolish, and your punishment is swift.");
        }
        else
        {
            punishment = false;
            System.Console.WriteLine("Your actions show wisdom, and you receive a boon.");
        }
        return punishment;
    }
}