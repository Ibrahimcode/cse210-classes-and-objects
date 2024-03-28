using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [
            new Square("Blue", 4),
            new Rectangle(5,4,"Red"),
            new Circle(5, "Green")
        ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}; Area: {Math.Round(shape.GetArea(), 2)}");
        }


    }
}