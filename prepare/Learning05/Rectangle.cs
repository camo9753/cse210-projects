public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width) : base()
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        double sqArea = _length * _width;
        return sqArea;
    }
}