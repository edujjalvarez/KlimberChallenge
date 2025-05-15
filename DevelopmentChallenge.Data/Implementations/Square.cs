using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Implementations
{
    public class Square : IGeometricShape
    {
        private readonly decimal _side;

        public Square(decimal side)
        {
            _side = side;
        }

        public Shape Shape => Shape.Square;

        public decimal CalculateArea()
        {
            return _side * _side;
        }

        public decimal CalculatePerimeter()
        {
            return _side * 4;
        }
    }
}
