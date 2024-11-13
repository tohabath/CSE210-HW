using System.Net.NetworkInformation;

public class Circle : Shape
{
    //ATTR
    private double _radius;
    //CONST
    public Circle(string color, double side) : base (color)
    {
        _radius = side;
    }
    //METH
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
