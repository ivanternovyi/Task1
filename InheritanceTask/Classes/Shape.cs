using System;

namespace InheritanceTask
{
    public enum Colour
    {
        Green,
        White,
        Orange,
        Olive,
        Blue
    }

    public abstract class Shape
    {
        private Colour contour;
        private Colour filling;
        private double contourWidth;

        protected Shape(Colour contour = Colour.Green, Colour filling = Colour.Green, double width = 0)
        {
            this.contour = contour;
            this.filling = filling;
            if(width < 0)
                throw new ArgumentException("Value should be > 0");
            contourWidth = width;
        }

        public override string ToString()
        {
            return  $"Countour(Colour: { contour }, Width: { contourWidth }), Filling: {filling} ";
        }

        public abstract double Square();
        
        public abstract double Perimeter();

    }
}