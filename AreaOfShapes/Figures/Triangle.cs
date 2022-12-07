namespace AreaOfShapes.Figures;

public class Triangle : Figure
{
    private double _a;
    private double _b;
    private double _c;
    private bool _isTriangleRight;
    public bool IsTriangleRight => _isTriangleRight;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("",
                "The side cannot be less than or equal to zero");
        }
        
        this._a = a;
        this._b = b;
        this._c = c;
        this._isTriangleRight = DetermineRightTriangle(a, b, c);
    }

    protected override double CalculateArea()
    {
        var p = (this._a + this._b + this._c) / 2;
        return Math.Sqrt(p * (p - this._a) * (p - this._b) * (p - this._c));
    }

    public static bool DetermineRightTriangle(double a, double b, double c)
    {
        var hyp = new[] { a, b, c }.Max();
        return hyp * hyp * 2 == a * a + b * b + c * c;
    }
}