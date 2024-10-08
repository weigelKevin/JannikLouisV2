namespace Geometrie;

public abstract class Shape
{
    public virtual double CalculateArea()
    {
        return 0.0;
    }
}

public class Circle:Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * (Radius*Radius);
    }
}

public class Rectangel : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangel(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

public class Square : Shape
{
    public double Length { get; set; }

    public Square(double length)
    {
        Length = length;
    }

    public override double CalculateArea()
    {
        return Length * Length;
    }
}