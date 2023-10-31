using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZakharovaYV.Sprint3.Review.V2.Lib
{
    public class DataService
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
                y = Math.Round((Math.Cos(x) / (x - 0.7)) - Math.Sin(x) * 12 * x + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;

        }
    }
}