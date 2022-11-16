using MindBox.FigureCalculator.Interfaces;

namespace MindBox.FigureCalculator.Implementations
{
    public class Circle : IFigure, ICircle
    {
        private readonly double _radius;
        public double Radius
        {
            get => _radius;
            init
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentException("The radius can not be less than or equal to zero.");
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }

        public double GetPerimeter()
        {
            var diameter = 2.0 * Radius;
            var perimetr = Math.PI * diameter;
            return perimetr;
        }
    }
}
