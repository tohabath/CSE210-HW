public abstract class Shape
{
    //ATTR
    private string _color;
    //CONST
    public Shape(string color)
    {
        _color = color;
    }
    //METH
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}