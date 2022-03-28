using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figures
{
    internal class Circle : IFigure
    {

        private float radius;
        Circle(float r)
        {
            radius = r;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
