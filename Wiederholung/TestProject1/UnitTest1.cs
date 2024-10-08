namespace TestProject1;
using Geometrie;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Circle g1 = new Circle(1);
        Rectangel g2 = new Rectangel(2, 3);
        Square g3 = new Square(3);
        Assert.AreEqual(g1.CalculateArea(),Math.PI);
        Assert.AreEqual(g2.CalculateArea(),2*3);
        Assert.AreEqual(g3.CalculateArea(),9);
        
    }
}