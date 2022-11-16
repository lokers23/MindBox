using MindBox.FigureCalculator.Figures.Helpers;

namespace MindBox.FigureCalculator.Interfaces
{
    internal interface ITriangle
    {
        public Side SideA { get; init; }
        public Side SideB { get; init; }
        public Side SideC { get; init; }
        public bool IsRightTrianle();
    }
}
