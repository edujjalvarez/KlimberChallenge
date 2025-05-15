using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Implementations
{
    public class ItalianReport : BaseReport
    {
        protected override string Title => "Rapporto sulle forme";
        protected override string Line(int quantity, decimal area, decimal perimeter, Shape shape)
        {
            return $"{quantity} {GetShapeName(shape, quantity)} | {Area} {area:#.##} | {Perimeter} {perimeter:#.##} <br/>";
        }
        protected override string Total => "TOTALE";
        protected override string Shapes => "forme";
        protected override string Perimeter => "Perimetro";
        protected override string Area => "Area";
        protected override string EmptyList => "Elenco di forme vuoto!";
        protected override string GetShapeName(Shape shape, int quantity)
        {
            switch (shape)
            {
                case Shape.Square: return quantity == 1 ? "Quadrato" : "Quadrati";
                case Shape.Circle: return quantity == 1 ? "Cerchio" : "Cerchi";
                case Shape.EquilateralTriangle: return quantity == 1 ? "Triangolo Equilatero" : "Triangoli Equilateri";
                case Shape.Trapezoid: return quantity == 1 ? "Trapezio" : "Trapezi";
                case Shape.Rectangle: return quantity == 1 ? "Rettangolo" : "Rettangoli";
                default: return string.Empty;
            }
        }
    }
}
