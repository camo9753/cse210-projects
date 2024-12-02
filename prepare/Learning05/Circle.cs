public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) : base()
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double sqArea = Math.PI * _radius * _radius;
        return sqArea;
    }
}