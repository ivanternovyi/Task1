using System;
using System.Collections.Generic;

namespace InheritanceTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> dataShapes = new List<Shape>();
            try
            {
                dataShapes.Add(new Circle(Colour.Olive, Colour.Orange, 12.5, 3.5));
                dataShapes.Add(new Rectangle(Colour.Green, Colour.Olive, 12.5, 1.0, 2));
                dataShapes.Add(new Parallelepiped(Colour.White, Colour.Olive, 10, 1, 3, 1.2));
                dataShapes.Add(new Cylindr(Colour.Orange, Colour.White, 2, 1, 14));
                dataShapes.Add(new Rectangle(Colour.Blue, Colour.White, 2, 5, 1));
                Console.WriteLine($"Total perimeter: {Task.TotalPerimeter(dataShapes)}");
                Console.WriteLine($"Total square: {Task.TotalSquare(dataShapes)}");
                Task.OutputShapes(dataShapes);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}