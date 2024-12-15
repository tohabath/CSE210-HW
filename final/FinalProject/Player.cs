public class Player : Stats {
    //ATTR
    private static int _Health;
    private static int _Damage;
    private static bool _Status;

    //CONST
    public Player() : base(_Health, _Damage, _Status)
    {
        SetHealth(12);
        SetDamage(3);
        SetStatus(true);
    }
    //METH
    public void TakeHealth(int healing)
    {
        SetHealth(GetHealth() + healing);
        System.Console.WriteLine($"You've been healed for {healing} health ({GetHealth()})!");
    }
    public override void TakeDamage(int damage)
    {
        SetHealth(GetHealth() - damage);
        if (GetHealth() <= 0)
        {
            System.Console.WriteLine($"You've been hit for {damage} damage (0)!");
            SetStatus(false);
            Die();
        }
        else
        {
            System.Console.WriteLine($"You've been hit for {damage} damage ({GetHealth()})!");
        }
    }
    public override void Die()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("You were defeated!");
        Console.Write("(Press ENTER to continue) ");
        Console.ReadLine();
    }
}