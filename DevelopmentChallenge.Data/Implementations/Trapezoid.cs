using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Implementations
{
    public class Trapezoid : IGeometricShape
    {
        private readonly decimal _majorBase;
        private readonly decimal _minorBase;
        private readonly decimal _height;
        private readonly decimal _side;

        public Trapezoid(decimal majorBase, decimal minorBase, decimal height, decimal side)
        {
            _majorBase = majorBase;
            _minorBase = minorBase;
            _height = height;
            _side = side;
        }

        public decimal CalculateArea()
        {
            return ((_majorBase + _minorBase) * _height) / 2;
        }

        public decimal CalculatePerimeter()
        {
            return _majorBase + _minorBase + (2 * _side);
        }

        public Shape Shape => Shape.Trapezoid;
    }
}
