using MindBox.FigureCalculator.Implementations;
using MindBox.FigureCalculator.Interfaces;
using MindBox.FigureCalculator.Services;

namespace MindBox.UnitTests
{
    public class FigureCalculatorTests
    {
        [Fact]
        public void GetAreaTriangle_ValidSides_ShouldReturnResult()
        {
            //Arrange
            var sideA = 4.0;
            var sideB = 4.0;
            var sideC = 4.0;

            var triangle = new Triangle(sideA, sideB, sideC);
            var figureService = new FigureService(triangle);

            var expected = Math.Round(6.9282032302755091741097853660235, 2);

            //Act
            var actual = Math.Round(figureService.GetArea(), 2);

            //Assert
            Assert.Equal(expected, actual);
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

        [Fact]
        public void GetAreaCircle_ValidRadius_ShouldReturnArea()
        {
            //Arrange
            var radius = 2.0;

            var circle = new Circle(radius);
            var figureService = new FigureService(circle);

            var expected = Math.Round(12.5663706);

            //Act
            var actual = Math.Round(figureService.GetArea());

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}