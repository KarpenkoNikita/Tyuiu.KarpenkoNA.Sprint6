using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KarpenkoNA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int[] columnValues = new int[rows];

            
            for (int i = 0; i < rows; i++)
            {
                columnValues[i] = matrix[i, 4];
            }
            
            Array.Sort(columnValues);
          
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = columnValues[i];
            }
            return matrix;
        }
    }
}
