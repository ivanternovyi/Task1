using System;

namespace InheritanceTask
{
    public class Parallelepiped:Rectangle
    {
        private double thirdSide;

        public Parallelepiped(Colour contour, Colour filling, double width = 0, double first = 0, double second = 0, 
            double third = 0) : base(contour, filling, width, first, second)
        {
            if(third < 0)
                throw new ArgumentException("Value should be > 0");
            thirdSide = third;
        }
        
        public override void Output()
        {
            Console.Write("Parallelepiped -> ");
            base.Output();
            Console.WriteLine($", Perimeter: { Perimeter() }, Square: { Square() }, Volume: { Volume() } ");
        }

        public override double Square()
        {
            
            var result = 2 * firstSide * secondSide  + 2 * (firstSide + secondSide) * thirdSide;
            return result;
        }
        
        public override double Perimeter()
        {
            var result = 4 * (firstSide + secondSide + thirdSide);
            return result;
        }

        public double Volume()
        {
            var result = firstSide * secondSide * thirdSide;
            return result;
        }

    }
}