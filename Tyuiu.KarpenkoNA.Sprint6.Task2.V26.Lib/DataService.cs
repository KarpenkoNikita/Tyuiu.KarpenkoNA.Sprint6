using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KarpenkoNA.Sprint6.Task2.V26.Lib
{
    public class DataService : ISprint6Task2V26
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
                y = Math.Round((Math.Sin(x) + ((Math.Cos(2 * x)) / 2) - 1.5 * x), 2);
                valueArray[count] = y;
                count++;

            }
            return valueArray;
        }
    }
}
