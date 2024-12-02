public class Square : Shape
{
    private double _side;

    public Square(double side) : base()
    {
        _side = side;
    }
    public override double GetArea()
    {
        double sqArea = _side * _side; 
        return sqArea;
    }
}