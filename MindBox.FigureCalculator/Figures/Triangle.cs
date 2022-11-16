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
            var isRightTriangleA = Math.Round(SideA.Legth * SideA.Legth, 2) == Math.Round((SideB.Legth * SideB.Legth + SideC.Legth * SideC.Legth), 2);
            var isRightTriangleB = Math.Round(SideB.Legth * SideB.Legth, 2) == Math.Round((SideA.Legth * SideA.Legth + SideC.Legth * SideC.Legth), 2);
            var isRightTriangleC = Math.Round(SideC.Legth * SideC.Legth, 2) == Math.Round((SideA.Legth * SideA.Legth + SideB.Legth * SideB.Legth), 2);

            if (isRightTriangleA || isRightTriangleB || isRightTriangleC)
            {
                return true;
            }

            return false;
        }
    }
}