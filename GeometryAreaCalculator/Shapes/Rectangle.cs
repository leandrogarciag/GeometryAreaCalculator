using System;

namespace GeometryAreaCalculator.Shapes
{
    public class Rectangle : Shape
    {
        private double _base;
        private double _height;

        public double Base
        {
            get => _base;
            set
            {
                ValidateInput(value, nameof(Base));
                _base = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                ValidateInput(value, nameof(Height));
                _height = value;
            }
        }

        public Rectangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Base * Height;
        }
    }
}
