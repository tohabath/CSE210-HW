public class Stats {
    //ATTR
    private int _Health;
    private int _Damage;
    private bool _Status = true;
    //CONST
    public Stats(int health, int damage, bool status)
    {
        _Health = health;
        _Damage = damage;
        _Status = status;
    }
    //METH
    public int GetHealth()
    {
        return _Health;
    }
    public int GetDamage()
    {
        return _Damage;
    }
    public bool GetStatus()
    {
        return _Status;
    }
    public void SetHealth(int health)
    {
        _Health = health;
    }
    public void SetDamage(int damage)
    {
        _Damage = damage;
    }
    public void SetStatus(bool status)
    {
        _Status = status;
    }
    public virtual void TakeDamage(int damage)
    {
        SetHealth(GetHealth() - damage);
        if (GetHealth() <= 0)
        {
            SetStatus(false);
            Die();
        }
    }
    public virtual void Die()
    {

    }

}