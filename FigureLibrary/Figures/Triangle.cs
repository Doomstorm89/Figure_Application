using FigureLibrary.Helpers;
using FigureLibrary.Interfaces;

namespace FigureLibrary.Figures
{
    public class Triangle : BaseFigure, IGetPerimeter, IIsFigureRight
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA 
        {
            get => sideA;
            set
            {
                if (value > 0)
                {
                    sideA = value;
                }
                else
                {
                    sideA = 0;
                }
            }
        }

        public double SideB 
        {
            get => sideB;
            set
            {
                if (value > 0)
                {
                    sideB = value;
                }
                else
                {
                    sideB = 0;
                }
            }
        }

        public double SideC
        {
            get => sideC;
            set
            {
                if (value > 0)
                {
                    sideC = value;
                }
                else
                {
                    sideC = 0;
                }
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetSquare()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(
                halfPerimeter * 
                (halfPerimeter - SideA) * 
                (halfPerimeter - SideB) * 
                (halfPerimeter - SideC)
            );
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public bool IsFigureRight()
        {           
            var aSquare = SideA * SideA;
            var bSquare = SideB * SideB;
            var cSquare = SideC * SideC;

            return DoubleComparer.Compare(aSquare + bSquare, cSquare) ||
                   DoubleComparer.Compare(bSquare + cSquare, aSquare) ||
                   DoubleComparer.Compare(cSquare + aSquare, bSquare);
        }
    }
}
