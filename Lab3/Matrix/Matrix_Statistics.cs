using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix
{
    class Matrix_Statistics
    {
        private double sum, avarage, max_value;
        private int count_non_zero;

        public Matrix_Statistics(IMatrix matrix)
        {
            sum = 0;
            max_value = double.MinValue;
            count_non_zero = 0;
            for (int i = 0; i < matrix.Row_Count; i++)
            {
                for (int j = 0; j < matrix.Column_Count; j++)
                {
                    double value = matrix.Get(i, j);
                    sum += value;
                    if (value != 0) count_non_zero++;
                    if (max_value < value) max_value = value;
                }
            }
            avarage = sum / (matrix.Row_Count * matrix.Column_Count);
        }
        public double Sum { get { return sum; } }
        public double Avarage { get { return avarage; } }
        public double MaxValue { get { return max_value; } }
        public int CountNonZero { get { return count_non_zero; } }
    }
}
