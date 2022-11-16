namespace MindBox.FigureCalculator.Figures.Helpers
{
    public class Side
    {
        private double _length;
        public double Legth
        {
            get => _length;
            init
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("The length of the side can not be less than or equal to zero.");
                }
            }
        }

        public Side(double length)
        {
            Legth = length;
        }
    }
}
