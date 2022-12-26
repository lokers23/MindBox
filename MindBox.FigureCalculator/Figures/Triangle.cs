using MindBox.FigureCalculator.Figures.Helpers;
using MindBox.FigureCalculator.Interfaces;

namespace MindBox.FigureCalculator.Implementations
{
    public class Triangle : IFigure, ITriangle
    {
        public Side SideA { get; init; }
        public Side SideB { get; init; }
        public Side SideC { get; init; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!(sideA + sideB > sideC) || !(sideC + sideB > sideA) || !(sideA + sideC > sideB))
            {
                throw new ArgumentException("Triangle with such sides does not exist.");
            }

            SideA = new Side(sideA);
            SideB = new Side(sideB);
            SideC = new Side(sideC);
        }

        public double GetArea()
        {
            var semiPerimeter = GetPerimeter() / 2.0;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA.Legth) * (semiPerimeter - SideB.Legth) * (semiPerimeter - SideC.Legth));
            return area;
        }

        public double GetPerimeter()
        {
            var perimeter = (SideA.Legth + SideB.Legth + SideC.Legth);
            return perimeter;
        }

        public bool IsRightTrianle()
        {
            var accuracy = 0.00001;
            var squareSideA = SideA.Legth * SideA.Legth;
            var squareSideB = SideB.Legth * SideB.Legth;
            var squareSideC = SideC.Legth * SideC.Legth;

            var isRightTriangleA = Math.Abs((squareSideA - (squareSideB + squareSideC))) < accuracy;
            var isRightTriangleB = Math.Abs((squareSideB - (squareSideA + squareSideC))) < accuracy;
            var isRightTriangleC = Math.Abs((squareSideC - (squareSideA + squareSideB))) < accuracy;

            if (isRightTriangleA || isRightTriangleB || isRightTriangleC)
            {
                return true;
            }

            return false;
        }
    }
}