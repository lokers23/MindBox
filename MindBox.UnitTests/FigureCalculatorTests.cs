using MindBox.FigureCalculator.Implementations;
using MindBox.FigureCalculator.Services;

namespace MindBox.UnitTests
{
    public class FigureCalculatorTests
    {
        [Theory]
        [InlineData(4.0, 4.0, 4.0, 6.92820)]
        [InlineData(5.0, 4.0, 4.0, 7.80624)]
        [InlineData(5.0, 7.0, 4.0, 9.79795)]
        [InlineData(5.5, 7.0, 4.0, 10.97849)]
        [InlineData(1.0, 1.0, 1.0, 0.43301)]
        public void GetAreaTriangle_ValidSides_ShouldReturnTrue(double sideA, double sideB, double sideC, double expected)
        {
            //Arrange
            var accurancy = 0.0001;

            var triangle = new Triangle(sideA, sideB, sideC);
            var figureService = new FigureService(triangle);

            //Act
            var actual = figureService.GetArea();

            var isEqual = Math.Abs(actual - expected) < accurancy;
            //Assert
            Assert.True(isEqual);
        }

        [Theory]
        [InlineData(4.0, 4.0, 4.0, 6.92720)]
        [InlineData(5.0, 4.0, 4.0, 7.80524)]
        [InlineData(5.0, 7.0, 4.0, 9.79295)]
        [InlineData(5.5, 7.0, 4.0, 10.96849)]
        [InlineData(1.0, 1.0, 1.0, 0.43401)]
        public void GetAreaTriangle_ValidSides_ShouldReturnFalse(double sideA, double sideB, double sideC, double expected)
        {
            //Arrange
            var accurancy = 0.0001;

            var triangle = new Triangle(sideA, sideB, sideC);
            var figureService = new FigureService(triangle);

            //Act
            var actual = figureService.GetArea();

            var isEqual = Math.Abs(actual - expected) < accurancy;
            //Assert
            Assert.False(isEqual);
        }

        [Fact]
        public void Triangle_InvalidSides_ThrowException()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var sideA = 0.0;
                var sideB = -1.0;
                var sideC = 0.0;

                var triangle = new Triangle(sideA, sideB, sideC);
            });
        }

        [Fact]
        public void Triangle_InvalidTriangle_ThrowException()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var sideA = 2.0;
                var sideB = 2.0;
                var sideC = 4.0;

                var triangle = new Triangle(sideA, sideB, sideC);
            });
        }

        [Fact]
        public void IsRigtTriangle_ValidSides_ShouldReturnTrue()
        {
            //Arrange
            var sideA = 4.0;
            var sideB = 4.0;
            var sideC = 5.6568542494923801952067548968388;

            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var actual = triangle.IsRightTrianle();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsRigtTriangle_ValidSides_ShouldReturnFalse()
        {
            //Arrange
            var sideA = 8.0;
            var sideB = 7.0;
            var sideC = 5.0;

            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var actual = triangle.IsRightTrianle();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Circle_InValidRadius_ThrowException()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var radius = -2.0;

                var circle = new Circle(radius);
            });
        }

        [Theory]
        [InlineData(2.0, 12.56637)]
        [InlineData(3.0, 28.27433)]
        [InlineData(1.5, 7.06858)]
        [InlineData(2.5, 19.63495)]
        [InlineData(2.58, 20.91169)]
        [InlineData(3.78, 44.88833)]
        public void GetAreaCircle_Should_ReturnTrue(double radius, double expected)
        {
            //Arrange
            var accurancy = 0.0001;

            var circle = new Circle(radius);
            var figureService = new FigureService(circle);

            //Act
            var actual = figureService.GetArea();

            var isEqual = Math.Abs(expected - actual) < accurancy;
            //Assert
            Assert.True(isEqual);
        }

        [Theory]
        [InlineData(2.0, 12.56547)]
        [InlineData(3.0, 28.27445)]
        [InlineData(1.5, 7.06958)]
        [InlineData(2.5, 19.63424)]
        [InlineData(2.58, 20.9245)]
        [InlineData(3.78, 44.875783)]
        public void GetAreaCircle_Should_ReturnFalse(double radius, double expected)
        {
            //Arrange
            var accurancy = 0.0001;

            var circle = new Circle(radius);
            var figureService = new FigureService(circle);

            //Act
            var actual = figureService.GetArea();
            var isEqual = Math.Abs(expected - actual) < accurancy;

            //Assert
            Assert.False(isEqual);
        }
    }
}