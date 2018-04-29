using System;

namespace InheritanceTask
{
    public class Cylinder:Circle
    {
        private double height;

        public Cylinder(Colour contour, Colour filling, double width = 0, double radius = 0, double height = 0)
            : base(contour, filling, width, radius)
        {
            if(height < 0)
                throw new ArgumentException("Value should be > 0");
            this.height = height;
        }
        
        public override void Output()
        {
            Console.Write("Cylinder -> ");
            base.Output();
            Console.WriteLine($", Perimeter: { Perimeter() }, Square: { Square() }, Volume: { Volume() } ");
        }

        public override double Square()
        {
            
            var result = 2 * Math.PI * Math.Pow(radius, 2)  + 2 * Math.PI * radius * height;
            return result;
        }
        
        public override double Perimeter()
        {
            var result = 4 * Math.PI * radius + 2 * height;
            return result;
        }

        public double Volume()
        {
            var result = Math.PI * Math.Pow(radius, 2) * height;
            return result;
        }

    }
}