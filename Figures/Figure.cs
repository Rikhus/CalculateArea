using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;

        public double Area => _area.Value;

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        protected abstract double CalculateArea();
    }
}
