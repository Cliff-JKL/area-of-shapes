using AreaOfShapes.Figures;

namespace AreaOfShapes.Tests;

public class Tests
{
    [SetUp]
    public void Setup() {}

    [Test]
    public void AreaCircleCalculateArea()
    {
        Assert.That(new Circle(11.1).Area, Is.EqualTo(Math.PI * 11.1 * 11.1));
    }
    
    [Test]
    public void AreaCircleNegativeRadius()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var circleArea = new Circle(-5.2).Area;
        });
    }

    [Test]
    public void AreaTriangleCalculateArea()
    {
        const double a = 7, b = 8, c = 9;
        const double p = (a + b + c) / 2;
        Assert.That(new Triangle(a, b, c).Area, Is.EqualTo(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
    }
    
    [Test]
    public void AreaTriangleRightTriangle()
    {
        Assert.That(new Triangle(8, 15, 17).IsTriangleRight, Is.EqualTo(true));
    }

    [Test]
    public void AreaTriangleNotRightTriangle()
    {
        Assert.That(new Triangle(10, 15, 17).IsTriangleRight, Is.EqualTo(false));
    }
    
    [Test]
    public void AreaTriangleNegativeSides()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var triangleArea = new Triangle(3, 4, -5).Area;
        });
    }
}