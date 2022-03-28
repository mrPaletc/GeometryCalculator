using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figures
{
    internal class UnknownFigure:IFigure
    {
        private IFigure figure;
        UnknownFigure(IFigure newFigure)
        {
            figure = newFigure;
        }

        public double GetArea()
        {
            return figure.GetArea();
        }
    }
}
