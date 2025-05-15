using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Contracts
{
    public interface IGeometricShape
    {
        decimal CalculateArea();

        decimal CalculatePerimeter();

        Shape Shape { get; }
    }
}
