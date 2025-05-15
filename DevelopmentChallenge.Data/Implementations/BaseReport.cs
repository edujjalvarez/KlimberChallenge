using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Implementations
{
    public abstract class BaseReport : IReport
    {
        protected abstract string Title { get; }
        protected abstract string Line(int quantity, decimal area, decimal perimeter, Shape shape);
        protected abstract string Total { get; }
        protected abstract string Shapes { get; }
        protected abstract string Perimeter { get; }
        protected abstract string Area { get; }
        protected abstract string EmptyList { get; }

        public string Generate(List<IGeometricShape> geometricShapes)
        {
            var sb = new StringBuilder();

            if (!geometricShapes.Any())
            {
                sb.Append($"<h1>{EmptyList}</h1>");
            }
            else
            {
                sb.Append($"<h1>{Title}</h1>");

                var totalArea = 0m;
                var totalPerimeter = 0m;
                var quantityByShape = new Dictionary<Shape, int>();
                var areaByShape = new Dictionary<Shape, decimal>();
                var perimeterByShape = new Dictionary<Shape, decimal>();

                foreach (var forma in geometricShapes)
                {
                    var shape = forma.Shape;
                    var area = forma.CalculateArea();
                    var perimeter = forma.CalculatePerimeter();

                    totalArea += area;
                    totalPerimeter += perimeter;

                    if (quantityByShape.ContainsKey(shape))
                    {
                        quantityByShape[shape]++;
                        areaByShape[shape] += area;
                        perimeterByShape[shape] += perimeter;
                    }
                    else
                    {
                        quantityByShape[shape] = 1;
                        areaByShape[shape] = area;
                        perimeterByShape[shape] = perimeter;
                    }
                }

                foreach (var shape in quantityByShape.Keys)
                {
                    sb.Append(Line(quantityByShape[shape], areaByShape[shape], perimeterByShape[shape], shape));
                }

                sb.Append($"{Total}:<br/>");
                sb.Append($"{geometricShapes.Count} {Shapes} ");
                sb.Append($"{Perimeter} {totalPerimeter:#.##} ");
                sb.Append($"{Area} {totalArea:#.##}");
            }

            return sb.ToString();
        }

        protected abstract string GetShapeName(Shape shape, int quantity);
    }
}
