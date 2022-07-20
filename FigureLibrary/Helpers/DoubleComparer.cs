namespace FigureLibrary.Helpers
{
    internal static class DoubleComparer
    {
        private const double Difference = 0.00001;

        public static bool Compare(double a, double b)
        {
            return Math.Abs(a - b) <= Difference;
        }
    }
}
