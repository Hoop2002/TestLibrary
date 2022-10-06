using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;
using System;
using static System.Net.Mime.MediaTypeNames;


namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AreaCircleTest1()
        {
            int radius = 5;
            double excpected = 78.54;
            double result = AreaCalculatin.CircleArea(radius);
            Assert.AreEqual(excpected, result, "Test is not Correct");
        }

        [TestMethod]
        public void AreaCircleTest2()
        {
            int radius = 50;
            double excpected = 7853.98;
            var result = AreaCalculatin.CircleArea(radius);
            Assert.AreEqual(excpected, result, "Test is not Correct");
        }

        [TestMethod]
        public void AreaCircleTest3()
        {
            int radius = -999;
            double excpected = 0;
            var result = AreaCalculatin.CircleArea(radius);
            Assert.AreEqual(excpected, result, "Test is not Correct");
        }

        [TestMethod]
        public void AreaTriangle1()
        {
            int a = 5;
            int b = 5;
            int c = 5;
            double excpected = 10.83;
            var result = AreaCalculatin.TriangleArea(a, b, c);
            Assert.AreEqual(excpected, result, "Test is not Correct");
        }

        [TestMethod]
        public void AreaTriangle2()
        {
            int a = 20;
            int b = 20;
            int c = 20;
            double excpected = 173.21;
            var result = AreaCalculatin.TriangleArea(a, b, c);
            Assert.AreEqual(excpected, result, "Test is not Correct");
        }

        [TestMethod]
        public void AreaTriangle3()
        {
            int a = 150;
            int b = 100;
            int c = 1;
            double excpected = 0;
            var result = AreaCalculatin.TriangleArea(a, b, c);
            Assert.AreEqual(excpected, result, "Test is not Correct");
        }




    }
}
