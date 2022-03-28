using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figures
{
    internal class Triangle : IFigure
    {
        private List<float> sideList;
        Triangle(float a, float b, float c)
        {
            if(a<=0)
            {
                throw new ArgumentException("sideA не может быть меньше нуля");
            }
            if (b <= 0)
            {

                throw new ArgumentException("sideB не может быть меньше нуля");
            }
            if (c <= 0)
            {

                throw new ArgumentException("sideC не может быть меньше нуля");
            }
            sideList.Add(a);
            sideList.Add(b);
            sideList.Add(c);
            sideList.Sort();
            if (sideList[2] < sideList[1] + sideList[0])
            {
                throw new ArgumentException("Такой треугольник не существует");
            }
        }
        public double GetArea()
        {
            float p = GetP();
            return Math.Sqrt(p*(p- sideList[0]) *(p- sideList[1]) *(p- sideList[2]));
        }
        private float GetP()
        {
            return (sideList[0] + sideList[1] + sideList[2]) / 2;
        }
        public bool IsRightTriangle()
        {
            return Math.Pow(sideList[2], 2) == Math.Pow(sideList[1], 2) + Math.Pow(sideList[0], 2);
        }
    }
}
