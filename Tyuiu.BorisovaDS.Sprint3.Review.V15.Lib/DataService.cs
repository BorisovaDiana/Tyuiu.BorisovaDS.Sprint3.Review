using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorisovaDS.Sprint3.Review.V15.Lib
{
    public class DataService : ISprint3Task7V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) + (2 * x) * Math.Pow(3, -1) - Math.Cos(x) * 4 * x, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
