using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Figures.Primitives
{
    public class Triangle : Figure
    {

        private Lazy<bool> _isRectangular;

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool IsRectangular => _isRectangular.Value;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException("Triangle side can't be less than 0");
            }
            if(a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("This triangle does not exists");
            }

            A = a;
            B = b;
            C = c;

            _isRectangular = new Lazy<bool>(CheckIsRectangular);
        }

        protected bool CheckIsRectangular()
        {
            var maxSide = new[] { A, B, C }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == Math.Pow(A,2) + Math.Pow(B, 2) + Math.Pow(C, 2);
        }

        protected override double CalculateArea()
        {
            double P = (A + B + C) / 2;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}
