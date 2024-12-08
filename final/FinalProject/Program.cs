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
        Stats stats = new();
        Story story = new();
        //METH
        while (RunningProgram)
        {
            settings.HandleSettings();
            problem.BuildProblemSet(settings.GetTable(), settings.GetProblemType());
            player.SetHealth(12);
            player.SetDamage(3);
            story.DetermineRounds(settings.GetDifficulty());
            if (story.GetRounds() > 0)
            {
                story.GenerateStory();
                choice.HandleChoice();
                enemies.SetHealth(24);
                enemies.SetDamage(2);
                enemies.PresentEnemy();
                while (enemies.GetHealth() > 0)
                {
                    problem.HandleProblem(settings.GetTable());
                    if (problem.GetCorrect())
                    {
                        enemies.TakeDamage(player.GetDamage() + problem.GetMultiplier());
                    }
                    else
                    {
                        player.TakeDamage(enemies.GetDamage() + problem.GetMultiplier());
                        if (player.GetGameOver())
                        {
                            RunningProgram = false;
                        }
                    }
                }

            }
        }
    }
}