public class Rectangle : Shape
{
    //ATTR
    private double _length;
    private double _width;
    //CONST
    public Rectangle(string color, double length, double width) : base(color)
    {
       _length = length;
       _width = width;
    }
    //METH
    public override double GetArea()
    {
        return _length * _width;
    }
}