using System;
using System.Collections.Generic;
using NUnit.Framework;
using InheritanceTask;

namespace TestTask
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCircleSquare()
        {
            var obj = new Circle(Colour.Blue, Colour.Green, 2, 6);
            var res = obj.Square();
            Assert.AreEqual(Math.Round(res, 3), 113,097d);
        }
        
        [Test]
        public void TestCirclePerimeter()
        {
            var obj = new Circle(Colour.Blue, Colour.Green, 2, 6);
            var res = obj.Perimeter();
            Assert.AreEqual(Math.Round(res, 3), 37.699d);
        }
        
        [Test]
        public void TestCylinderSquare()
        {
            var obj = new Cylinder(Colour.Orange, Colour.White, 2, 1, 14);
            var res = obj.Square();
            Assert.AreEqual(Math.Round(res, 0), 94d);
        }
        
        [Test]
        public void TestCylinderVolume()
        {
            var obj = new Cylinder(Colour.Orange, Colour.White, 2, 1, 14);
            var res = obj.Volume();
            Assert.AreEqual(Math.Round(res, 0), 44.0d);
        }
        
        [Test]
        public void TestCylinderPerimeter()
        {
            var obj = new Cylinder(Colour.Orange, Colour.White, 2, 1, 14);
            var res = obj.Perimeter();
            Assert.AreEqual(Math.Round(res, 3), 40.566d);
        }
        
        [Test]
        public void TestParallelepipedSquare()
        {
            var obj = new Parallelepiped(Colour.White, Colour.Olive, 10, 1, 3, 1.2);
            var res = obj.Square();
            Assert.AreEqual(Math.Round(res, 1), 15.6d);
        }
        
        [Test]
        public void TestParallelepipedPerimeter()
        {
            var obj = new Parallelepiped(Colour.White, Colour.Olive, 10, 1, 3, 1.2);
            var res = obj.Perimeter();
            Assert.AreEqual(Math.Round(res, 1), 20.8d);
        }
        
        [Test]
        public void TestParallelepipedVolume()
        {
            var obj = new Parallelepiped(Colour.White, Colour.Olive, 10, 1, 3, 1.2);
            var res = obj.Volume();
            Assert.AreEqual(Math.Round(res, 1), 3.6d);
        }

        [Test]
        public void TestRectangleSquare()
        {
            var obj = new Rectangle(Colour.Green, Colour.Olive, 12.5, 1.0, 2);
            var res = obj.Square();
            Assert.AreEqual(res, 2d);
        }
        
        [Test]
        public void TestRectanglePerimeter()
        {
            var obj = new Rectangle(Colour.Green, Colour.Olive, 12.5, 1.0, 2);
            var res = obj.Perimeter();
            Assert.AreEqual(res, 6d);
        }
        
        [Test]
        public void TestTaskTotalPerimeter()
        {
            var arrShapes = new List<Shape>();
            arrShapes.Add(new Rectangle(Colour.Green, Colour.Olive, 12.5, 1.0, 2));
            arrShapes.Add(new Circle(Colour.Blue, Colour.Green, 2, 6));
            var res = Task.TotalPerimeter(arrShapes);
            Assert.AreEqual(Math.Round(res, 0), 44d);
        }
        
        [Test]
        public void TestTaskTotalSquare()
        {
            var arrShapes = new List<Shape>();
            arrShapes.Add(new Cylinder(Colour.Orange, Colour.White, 2, 1, 14));
            arrShapes.Add(new Parallelepiped(Colour.White, Colour.Olive, 10, 1, 3, 1.2));
            var res = Task.TotalSquare(arrShapes);
            Assert.AreEqual(Math.Round(res, 0), 110d);
        }        
        
    }
}