using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        //CLASSES
        Circle circle = new("red", 3);
        Rectangle rectangle = new("yellow", 3, 4);
        Square square = new("blue", 3);

        //VAR
        List<Shape> shapes = new();
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        //FUNC
        foreach (Shape shape in shapes)
        {
            System.Console.WriteLine($"Color: {shape.GetColor()}\nArea: {shape.GetArea()}");
        }
        
    }
}