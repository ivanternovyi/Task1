using System;
using System.Collections.Generic;

namespace InheritanceTask
{
    public class Task
    {
        public static double TotalPerimeter(List<Shape> dataShapes)
        {
            double result = 0;
            foreach (var shape in dataShapes)
            {
                result += shape.Perimeter();
            }
            return result;
        }
        
        public static double TotalSquare(List<Shape> dataShapes)
        {
            double result = 0;
            foreach (var shape in dataShapes)
            {
                result += shape.Square();
            }
            return result;
        }
        
        public static void OutputShapes(List<Shape> dataShapes)
        {
            foreach (var shape in dataShapes)
            {
                Console.WriteLine(shape);
            }
        }

    }
}