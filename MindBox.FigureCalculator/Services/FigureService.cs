using MindBox.FigureCalculator.Interfaces;

namespace MindBox.FigureCalculator.Services
{
    public class FigureService
    {
        private readonly IFigure _figure;
        public FigureService(IFigure figure)
        {
            _figure = figure;
        }

        public double GetArea()
        {
            return _figure.GetArea();
        }

        public double GetPerimeter()
        {
            return _figure.GetPerimeter();
        }
    }
}
