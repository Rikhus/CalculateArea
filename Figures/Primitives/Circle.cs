using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Figures.Primitives
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if(radius < 0)
            {
                throw new ArgumentOutOfRangeException("Circle radius can't be less than 0");
            }
            Radius = radius;
        }

        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
