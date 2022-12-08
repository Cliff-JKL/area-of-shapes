namespace AreaOfShapes.Figures;

public class Circle : Figure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), radius,
                "The radius cannot be less than zero");
        }

        this._radius = radius;
    }

    protected override double CalculateArea()
    {
        return Math.PI * this._radius * this._radius;
    }
}