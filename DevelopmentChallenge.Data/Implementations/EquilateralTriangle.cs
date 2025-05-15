using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Implementations
{
    public class EquilateralTriangle : IGeometricShape
    {
        private readonly decimal _side;

        public EquilateralTriangle(decimal side)
        {
            _side = side;
        }

        public decimal CalculateArea()
        {
            return (decimal)Math.Sqrt(3) / 4 * _side * _side;
        }

        public decimal CalculatePerimeter()
        {
            return _side * 3;
        }

        public Shape Shape => Shape.EquilateralTriangle;
    }
}
