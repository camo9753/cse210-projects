using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(20);
        Rectangle rect = new Rectangle(20,14);
        Circle circle = new Circle(5);
        square.SetColor("Blue");
        rect.SetColor("Red");
        circle.SetColor("Orange");
        

        List<Shape> shapeList = new List<Shape>{square,rect,circle};
        foreach (Shape shape in shapeList)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"Area: {area}\nColor: {color}");
        }
    }
}