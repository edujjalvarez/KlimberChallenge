using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Contracts;
using DevelopmentChallenge.Data.Implementations;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var formaGeometrica = new FormaGeometrica(new SpanishReport());
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", formaGeometrica.Imprimir(new List<IGeometricShape>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var formaGeometrica = new FormaGeometrica(new EnglishReport());
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", formaGeometrica.Imprimir(new List<IGeometricShape>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IGeometricShape> { new Square(5) };
            var formaGeometrica = new FormaGeometrica(new SpanishReport());
            var resumen = formaGeometrica.Imprimir(cuadrados);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IGeometricShape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };
            var formaGeometrica = new FormaGeometrica(new EnglishReport());
            var resumen = formaGeometrica.Imprimir(cuadrados);
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IGeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };
            var formaGeometrica = new FormaGeometrica(new EnglishReport());
            var resumen = formaGeometrica.Imprimir(formas);
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52,03 | Perimeter 36,13 <br/>3 Equilateral Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IGeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };
            var formaGeometrica = new FormaGeometrica(new SpanishReport());
            var resumen = formaGeometrica.Imprimir(formas);
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 52,03 | Perímetro 36,13 <br/>3 Triángulos Equiláteros | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 115,73 Área 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapecioEnCastellano()
        {
            var trapecios = new List<IGeometricShape>
            {
                new Trapezoid(10, 6, 8, 5)
            };
            var formaGeometrica = new FormaGeometrica(new SpanishReport());
            var resumen = formaGeometrica.Imprimir(trapecios);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Área 64 | Perímetro 26 <br/>TOTAL:<br/>1 formas Perímetro 26 Área 64", resumen);
        }

        [TestCase]
        public void TestResumenListaConRectanguloEnItaliano()
        {
            var rectangulos = new List<IGeometricShape>
            {
                new Rectangle(10, 5)
            };
            var formaGeometrica = new FormaGeometrica(new ItalianReport());
            var resumen = formaGeometrica.Imprimir(rectangulos);
            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Rettangolo | Area 50 | Perimetro 30 <br/>TOTALE:<br/>1 forme Perimetro 30 Area 50", resumen);
        }
    }
}
