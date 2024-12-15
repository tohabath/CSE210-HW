using System;

class Program
{
    static void Main(string[] args)
    {
        //ATTR
        bool RunningProgram = true;
        //CLASS
        Choice choice = new();
        Enemies enemies = new();
        GameSettings settings = new();
        Player player = new();
        Problem problem = new();
        Score score = new();
        Story story = new();
        //METH
        while (RunningProgram)
        {
            problem.SetScore(0);
            settings.HandleSettings();
            problem.GetProblemSet().Clear();
            problem.BuildProblemSet(settings.GetTable(), settings.GetProblemType());
            story.DetermineRounds(settings.GetDifficulty());
            while (story.GetRounds() > 0 && player.GetStatus())
            {
                story.GenerateStory();
                bool punishment = choice.HandleChoice(settings.GetDifficulty());
                if (punishment)
                {
                    player.TakeDamage(3);
                }
                else
                {
                    player.TakeHealth(3);
                }
                enemies.PresentEnemy(15 - story.GetRounds());
                System.Console.WriteLine();
                while (enemies.GetStatus() && player.GetStatus())
                {
                    problem.HandleProblem(settings.GetTable(), settings.GetDifficulty());
                    if (problem.GetCorrect())
                    {
                        enemies.TakeDamage(player.GetDamage() + problem.GetMultiplier());
                    }
                    else
                    {
                        player.TakeDamage(enemies.GetDamage());
                    }
                }
                if (player.GetGameOver())
                {
                    RunningProgram = false;
                }
                else if (player.GetHealth() < 5)
                {
                    player.TakeHealth(6);
                }
            }
            score.HandleScoring(problem.GetScore(), player.GetHealth(), player.GetStatus());
            System.Console.Write("Play again? (y/n): ");
            string playerInput = Console.ReadLine();
            if (playerInput == "n")
            {
                RunningProgram = false;
            }
        }
    }
}