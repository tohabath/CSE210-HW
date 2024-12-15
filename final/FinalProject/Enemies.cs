public class Enemies : Stats {
    //ATTR
    private static int _Health;
    private static int _Damage;
    private static bool _Status;
    //CONST
    public Enemies() : base(_Health, _Damage, _Status)
    {
        SetHealth(12);
        SetDamage(3);
        SetStatus(true);
    }
    //METH
    public void PresentEnemy(int health)
    {
        SetHealth(health);
        SetDamage(3);
        SetStatus(true);
        System.Console.WriteLine();
        System.Console.WriteLine("An enemy approaches you!");
        Console.Write("(Press ENTER to continue) ");
        Console.ReadLine();
    }
    public override void TakeDamage(int damage)
    {
        SetHealth(GetHealth() - damage);
        if (GetHealth() <= 0)
        {
            System.Console.WriteLine($"You hit the enemy for {damage} damage (0)!");
            SetStatus(false);
            Die();
        }
        else
        {
            System.Console.WriteLine($"You hit the enemy for {damage} damage ({GetHealth()})!");
        }
    }
    public override void Die()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("You defeated the enemy!");
        Console.Write("(Press ENTER to continue) ");
        Console.ReadLine();
    }
}