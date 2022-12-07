namespace AreaOfShapes;

public abstract class Figure
{
    private Lazy<double> _area;
    public double Area => _area.Value;

    protected Figure()
    {
        this._area = new Lazy<double>(CalculateArea);
    }

    protected abstract double CalculateArea();
}