public class Choice : Stats {
    //ATTR
    
    //METH
    public void HandleChoice()
    {
        System.Console.WriteLine("You spy a door with strang runes on one of the walls. Will you open it? (y/n)");
        Console.Write("> ");
        string playerChoice = Console.ReadLine();
        if (playerChoice == "y")
        {
            System.Console.WriteLine("You find a chest inside, filled with resources.");
            GiveReward();
            Console.Write("> ");
            Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("You ignore the door, and run into a trap.");
            GivePunishment();
            Console.Write("> ");
            Console.ReadLine();
        }

    }
    public void GiveReward()
    {

    }
    public void GivePunishment()
    {

    }
}