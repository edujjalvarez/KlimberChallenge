using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Implementations
{
    public class SpanishReport : BaseReport
    {
        protected override string Title => "Reporte de Formas";
        protected override string Line(int quantity, decimal area, decimal perimeter, Shape shape)
        {
            return $"{quantity} {GetShapeName(shape, quantity)} | {Area} {area:#.##} | {Perimeter} {perimeter:#.##} <br/>";
        }
        protected override string Total => "TOTAL";
        protected override string Shapes => "formas";
        protected override string Perimeter => "Perímetro";
        protected override string Area => "Área";
        protected override string EmptyList => "Lista vacía de formas!";

        protected override string GetShapeName(Shape shape, int quantity)
        {
            switch (shape)
            {
                case Shape.Square: return quantity == 1 ? "Cuadrado" : "Cuadrados";
                case Shape.Circle: return quantity == 1 ? "Círculo" : "Círculos";
                case Shape.EquilateralTriangle: return quantity == 1 ? "Triángulo Equilátero" : "Triángulos Equiláteros";
                case Shape.Trapezoid: return quantity == 1 ? "Trapecio" : "Trapecios";
                case Shape.Rectangle: return quantity == 1 ? "Rectángulo" : "Rectángulos";
                default: return string.Empty;
            }
        }
    }
}
