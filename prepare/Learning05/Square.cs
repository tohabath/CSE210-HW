public class Square : Shape
{
    //ATTR
    private double _side;
    //CONST
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }
    //METH
    public override double GetArea()
    {
        return _side * _side;
    }
}
