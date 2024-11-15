using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square(5, "purple");
        Shape rectangle = new Rectangle(3, 4, "green");
        Shape circle = new Circle(2, "blue");
        List<Shape> shapes = [square, rectangle, circle];
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}