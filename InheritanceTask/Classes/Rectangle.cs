using System;

namespace InheritanceTask
{
    public class Rectangle:Shape
    {
        protected double firstSide;
        protected double secondSide;
        
        public Rectangle(Colour contour, Colour filling, double width = 0, double first = 0, double second = 0 )
            : base(contour, filling, width)
        {
            if(first < 0 || second < 0)
                throw new ArgumentException("Value should be > 0");
            firstSide = first;
            secondSide = second;
        }

        public override string ToString()
        {
            return $"Rectangle -> {base.ToString()}, Perimeter: { Perimeter() }, Square: { Square() } ";
        }

        public override double Square()
        {
            var result = firstSide * secondSide;
            return result;
        }
        
        public override double Perimeter()
        {
            var result = 2 * (firstSide + secondSide);
            return result;
        }

    }
}