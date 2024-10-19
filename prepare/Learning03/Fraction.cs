using System.Security.Cryptography.X509Certificates;

class Fraction
{
    //ATTR
    private int _top;
    private int _bottom;

    //CONST
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _bottom = 1;
        _top = wholeNumber;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //METH
    //GET and SET
    public int GetTop()
    {
        return _top;
    }
    public int SetTop(int top)
    {
        _top = top;
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public int SetBottom(int bottom)
    {
        _bottom = bottom;
        return _bottom;
    }

    //OTHER
    public string GetFractionString()
    {
        return $"{_top} / {_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}