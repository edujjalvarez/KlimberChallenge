using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Implementations
{
    public class EnglishReport : BaseReport
    {
        protected override string Title => "Shapes report";
        protected override string Line(int quantity, decimal area, decimal perimeter, Shape shape)
        {
            return $"{quantity} {GetShapeName(shape, quantity)} | {Area} {area:#.##} | {Perimeter} {perimeter:#.##} <br/>";
        }
        protected override string Total => "TOTAL";
        protected override string Shapes => "shapes";
        protected override string Perimeter => "Perimeter";
        protected override string Area => "Area";
        protected override string EmptyList => "Empty list of shapes!";

        protected override string GetShapeName(Shape shape, int quantity)
        {
            switch (shape)
            {
                case Shape.Square: return quantity == 1 ? "Square" : "Squares";
                case Shape.Circle: return quantity == 1 ? "Circle" : "Circles";
                case Shape.EquilateralTriangle: return quantity == 1 ? "Equilateral Triangle" : "Equilateral Triangles";
                case Shape.Trapezoid: return quantity == 1 ? "Trapezoid" : "Trapezoids";
                case Shape.Rectangle: return quantity == 1 ? "Rectangle" : "Rectangles";
                default: return string.Empty;
            }
        }
    }
}
