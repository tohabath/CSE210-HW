public class Enemies : Stats {
    //ATTR
    private static int _Health;
    private static int _Damage;
    private static bool _Status;
    private List<string> _Names = new(["giant spider", "thief", "dark guardian", "wraith", "wyvern", "lynx", "very deeply disturbed penguin", "tax collector", "troll", "goblin", "swarm of bats", "rodent of unusual size", "bigfoot", "bear", "wolf", "cultist", "cougar", "rabid gang of trash pandas"]);
    private string _Name;
    private Random _Random = new();
    //CONST
    public Enemies() : base(_Health, _Damage, _Status)
    {
        SetHealth(12);
        SetDamage(3);
        SetStatus(true);
    }
    //METH
    public void ChooseName()
    {
        int randomName = _Random.Next(0, _Names.Count);
        _Name = _Names[randomName];
    }
    public string GetName()
    {
        return _Name;
    }
    public void PresentEnemy(int health)
    {
        ChooseName();
        SetHealth(health);
        SetDamage(3);
        SetStatus(true);
        System.Console.WriteLine();
        System.Console.WriteLine($"A {GetName()} approaches you!");
        Console.Write("(Press ENTER to continue) ");
        Console.ReadLine();
    }
    public override void TakeDamage(int damage)
    {
        SetHealth(GetHealth() - damage);
        if (GetHealth() <= 0)
        {
            System.Console.WriteLine($"You hit the {GetName()} for {damage} damage (0)!");
            SetStatus(false);
            Die();
        }
        else
        {
            System.Console.WriteLine($"You hit the {GetName()} for {damage} damage ({GetHealth()})!");
        }
    }
    public override void Die()
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"You defeated the {GetName()}!");
        Console.Write("(Press ENTER to continue) ");
        Console.ReadLine();
    }
}