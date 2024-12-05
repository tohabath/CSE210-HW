public class Stats {
    //ATTR
    private int _Health;
    private int _Damage;
    private bool _Status;
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
        _Health = _Health - damage;
        if (_Health <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {

    }

}