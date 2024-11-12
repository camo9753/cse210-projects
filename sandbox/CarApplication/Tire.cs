class Tire
{
    private double width;
    private double radius;
    private double aspectRatio;

    public Tire(double w, double ar, double r)
    {
        this.width = w;
        this.radius = r;
        this.aspectRatio = ar;
    }

    public void Display()
    {
        Console.WriteLine($"Tire Info - Width: {width}, Radius: {radius}, Aspect Ratio: {aspectRatio}");
    }
}