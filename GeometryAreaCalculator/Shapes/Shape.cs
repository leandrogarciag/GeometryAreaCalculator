using System;

namespace GeometryAreaCalculator.Shapes
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        protected virtual void ValidateInput(double value, string paramName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{paramName} debe ser mayor a cero.", paramName);
            }
        }
    }
}