using System;

class Program
{
    static void Main(string[] args)
    {
        //ATTR
        List<Goal> goals = new();
        int TotalPoints = 0;
        string userInput;
        bool NotFinished = true;
        //METH
        while (NotFinished)
        {
            userInput = "";
            System.Console.WriteLine("\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            System.Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            System.Console.WriteLine();
            if (userInput == "1")
            {
                System.Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                System.Console.Write("\nWhich type of goal do you want to make? Input a number: ");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    goals.Add(new SimpleGoal());
                    goals.Last().ConstructGoal();
                }
                else if (userInput == "2")
                {
                    goals.Add(new Eternal());
                    goals.Last().ConstructGoal();
                }
                else if (userInput == "3")
                {
                    goals.Add(new Checklist());
                    goals.Last().ConstructGoal();
                }
            }
            else if (userInput == "2")
            {
                System.Console.WriteLine("The goals are:");
                foreach (Goal x in goals)
                {
                    System.Console.Write($"{goals.IndexOf(x) + 1}. ");
                    x.DisplayGoal();
                    System.Console.WriteLine();
                }
                System.Console.WriteLine($"You currently have {TotalPoints} points.");
            }
            else if (userInput == "3")
            {
                System.Console.Write("Input file name: ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Goal x in goals)
                    {
                        outputFile.WriteLine($"{goals.IndexOf(x)}|{x.GetStringRep()}");
                    }
                }
                System.Console.WriteLine("Save complete!");
            }
            else if (userInput == "4")
            {
                goals.Clear();
                System.Console.Write("Input file name: ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    if (parts.Last() == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal());
                        goals.Last().LoadGoal(parts[1], parts[2], int.Parse(parts[3]), 0, 0, 0, bool.Parse(parts[4]));
                    }
                    else if (parts.Last() == "Eternal")
                    {
                        goals.Add(new Eternal());
                        goals.Last().LoadGoal(parts[1], parts[2], int.Parse(parts[3]), 0, 0, 0, bool.Parse(parts[4]));
                    }
                    else if (parts.Last() == "Checklist")
                    {
                        goals.Add(new Checklist());
                        goals.Last().LoadGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                    }
                }
                System.Console.WriteLine("Load complete!");
            }
            else if (userInput == "5")
            {
                System.Console.WriteLine("Which goal did you complete?");
                System.Console.Write("> ");
                userInput = Console.ReadLine();
                System.Console.WriteLine();
                foreach (Goal x in goals)
                {
                    if (goals.IndexOf(x) == int.Parse(userInput) - 1)
                    {
                        x.CompleteGoal();
                        TotalPoints += x.GetPoint();
                    }
                }
            }
            else if (userInput == "6")
            {
                NotFinished = false;
            }
        }

    }
}