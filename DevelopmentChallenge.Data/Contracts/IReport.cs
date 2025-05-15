using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Contracts
{
    public interface IReport
    {
        string Generate(List<IGeometricShape> geometricShapes);
    }
}
