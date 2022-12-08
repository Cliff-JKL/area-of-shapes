using AreaOfShapes.Figures;

namespace AreaOfShapes.Tests;

public class Tests
{
    [SetUp]
    public void Setup() {}

    [Test]
    public void AreaCircleCalculateArea()
    {
        var circle = new Circle(11.1);
        var area = circle.Area;
        
        Assert.That(area, Is.EqualTo(Math.PI * 123.21));
    }
    
    [Test]
    public void AreaCircleNegativeRadius()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var circleArea = new Circle(-5.2);
        });
    }

    [Test]
    public void AreaTriangleCalculateArea()
    {
        const double a = 7, b = 8, c = 9;
        
        const double p = (a + b + c) / 2;

        var triangle = new Triangle(a, b, c);
        var area = triangle.Area;
        
        Assert.That(area, Is.EqualTo(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
    }
    
    [Test]
    public void AreaTriangleRightTriangle()
    {
        var triangle = new Triangle(8, 15, 17);
        var isTriangleRight = triangle.IsTriangleRight;
        
        Assert.That(isTriangleRight, Is.EqualTo(true));
    }

    [Test]
    public void AreaTriangleNotRightTriangle()
    {
        var triangle = new Triangle(10, 15, 17);
        var isTriangleRight = triangle.IsTriangleRight;
        
        Assert.That(isTriangleRight, Is.EqualTo(false));
    }
    
    [Test]
    public void AreaTriangleNegativeSides()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var area = new Triangle(3, 4, -5);
        });
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var area = new Triangle(-3, 4, 5);
        });
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var area = new Triangle(3, -4, 5);
        });
    }
    
    [Test]
    public void AreaTriangleValidTriangle()
    {
        // Check if three side lengths are a triangle
        Assert.Throws<Exception>(() =>
        {
            var area = new Triangle(2, 2, 4);
        });
    }
}