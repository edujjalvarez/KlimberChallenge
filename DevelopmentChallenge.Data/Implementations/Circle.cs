using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Implementations
{
    public class Circle : IGeometricShape
    {
        private readonly decimal _radius;

        public Circle(decimal radius)
        {
            _radius = radius;
        }

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * _radius * _radius;
        }

        public decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * 2 * _radius;
        }

        public Shape Shape => Shape.Circle;
    }
}
