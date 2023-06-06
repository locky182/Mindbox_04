using Area;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Area.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public const double PI = Math.PI;
        public const int A = 45;

        [TestMethod]//1720
        public void CircleShouldShowAreaTest()
        {
            double radius = 23.4;
            double expected = 1720.0;
            double actual;

            Circle circle = new Circle(radius);
            Assert.AreEqual(expected,actual = circle.OperationAreaOfCircle(23.4));


        }
        [TestMethod]//217.98   12.6,34.6
        public void RightTriangleShoudShowAreaTest()
        {
            double a = 12.6;
            double b = 34.6;
           
            double expected = 217.98; 
            double actual;
            Right_Triangle right_Triangle = new Right_Triangle();
            Assert.AreEqual(expected, actual = right_Triangle.OperationAreaOfTriangle(a, b));
        }

        [TestMethod]//12.4, 34.6, 34.0
        public void RegularTriangleShoudShowAreaTest()
        {
            double a = 12.4;
            double b = 34.6;
            double sinOfCornerAandB = 34.0;
            double expected = 113.0;
            double actual;
            Regular_Triangle regular = new Regular_Triangle(12.4, 34.6, 34.0);
            Assert.AreEqual(expected, actual = regular.OperationAreaOfTriangle(a, b, sinOfCornerAandB));


        }
    }
}
