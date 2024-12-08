public class Player : Stats {
    //ATTR
    bool _GameOver = false;
    //METH
    public bool GetGameOver()
    {
        return _GameOver;
    }
    public void SetGameOver(bool check)
    {
        _GameOver = check;
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    public override void Die()
    {
        System.Console.WriteLine("You were defeated!");
        SetGameOver(true);
        Console.Write("> ");
        Console.ReadLine();

    }
}