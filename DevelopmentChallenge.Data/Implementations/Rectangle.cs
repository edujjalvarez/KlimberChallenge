using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Implementations
{
    public class Rectangle : IGeometricShape
    {
        private readonly decimal _base;
        private readonly decimal _height;

        public Rectangle(decimal baseSide, decimal height)
        {
            _base = baseSide;
            _height = height;
        }

        public decimal CalculateArea()
        {
            return _base * _height;
        }

        public decimal CalculatePerimeter()
        {
            return 2 * (_base + _height);
        }

        public Shape Shape => Shape.Rectangle;
    }
}
