class Bin
{
    //ATTR
    private string _denomination;
    private double _value;
    private int _quantity;

    //METHODS
    // CONSTRUCTOR
    public Bin(string denomination, double value, int quantity)
    {
        _denomination = denomination;
        _value = value;
        _quantity = quantity;
    }
    //OTHER
    public void ModifyQuantity(int exchange)
    {
        _quantity += exchange;
    }
    public double CountValue()
    {
        return _quantity * _value;
    }
}