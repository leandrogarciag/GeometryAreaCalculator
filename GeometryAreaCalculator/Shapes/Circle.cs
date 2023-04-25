using System;

namespace GeometryAreaCalculator.Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                ValidateInput(value, nameof(Radius));
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
