public class Enemies : Stats {
    //METH
    public void PresentEnemy()
    {
        System.Console.WriteLine("An enemy approaches you!");
        Console.Write("> ");
        Console.ReadLine();
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    public override void Die()
    {
        System.Console.WriteLine("You defeated the enemy!");
        Console.Write("> ");
        Console.ReadLine();
    }
}