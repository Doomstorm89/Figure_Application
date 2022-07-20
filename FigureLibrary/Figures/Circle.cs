namespace FigureLibrary.Figures
{
    public class Circle : BaseFigure
    {
        private const double PI = Math.PI;

        private double radius;
        public double Radius 
        {
            get => radius; 
            set
            {
                if(value > 0)
                {
                    radius = value;
                }
                else
                {
                    radius = 0;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return PI * Radius * Radius;
        }
    }
}
