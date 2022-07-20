using NUnit.Framework;
using FigureLibrary.Figures;

namespace Tests
{
    public class Tests
    {
        public class FigureGetSquareTest
        {
            [SetUp]
            public void Setup()
            {

            }

            [Test]
            public void ResultTest()
            {
                var circle = new Circle(5);
                Assert.AreEqual(circle.GetSquare(), 78,53981633974483);
            }
        }

        public class FigureIsFigureRightTest
        {
            [SetUp]
            public void Setup()
            {

            }

            [Test]
            public void ResultTest()
            {
                var triangle = new Triangle(5.0, 4.0, 3.0);
                Assert.AreEqual(triangle.IsFigureRight(), true);
            }
        }
    }
}