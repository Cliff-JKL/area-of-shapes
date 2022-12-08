namespace AreaOfShapes.Figures;

public class Triangle : Figure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private readonly bool _isTriangleRight;
    public bool IsTriangleRight => _isTriangleRight;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("",
                "The side cannot be less than or equal to zero");
        }

        if (a >= b + c || b >= a + c || c >= a + b)
        {
            throw new Exception(
                "The triangle cannot exist " +
                "(the sum of any two sides of a triangle is need to be greater than the 3rd side)");
        }

        this._a = a;
        this._b = b;
        this._c = c;
        
        this._isTriangleRight = this.DetermineRightTriangle();
    }

    protected override double CalculateArea()
    {
        // p is half the perimeter
        var p = (this._a + this._b + this._c) / 2;
        
        return Math.Sqrt(p * (p - this._a) * (p - this._b) * (p - this._c));
    }

    private bool DetermineRightTriangle()
    {
        double a = this._a, b = this._b, c = this._c;
        var hyp = new[] { a, b, c }.Max();
        
        return (hyp * hyp * 2).CompareTo(a * a + b * b + c * c) == 0;
    }
}