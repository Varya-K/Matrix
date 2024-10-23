using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix
{
    class Matrix_Initiator
    {
        static public void Fill_Matrix(IMatrix matrix, int count_non_zero, int max_value)
        {
            int element_count = matrix.Row_Count * matrix.Column_Count;
            Random rnd = new Random();
            if (count_non_zero <= element_count / 2)
            {
                for (int k = 0; k < count_non_zero; k++)
                {
                    int i, j;
                    do
                    {
                        i = rnd.Next(matrix.Row_Count);
                        j = rnd.Next(matrix.Column_Count);
                    } while (matrix.Get(i, j) != 0);
                    matrix.Set(rnd.Next(1, max_value), i, j);

                }
            }
            else
            {
                for (int i = 0; i < matrix.Row_Count; i++)
                {
                    for (int j = 0; j < matrix.Column_Count; j++)
                    {
                        matrix.Set(rnd.Next(1, max_value), i, j);
                    }
                }
                for (int k = 0; k < element_count - count_non_zero; k++)
                {
                    int i, j;
                    do
                    {
                        i = rnd.Next(matrix.Row_Count);
                        j = rnd.Next(matrix.Column_Count);
                    } while (matrix.Get(i, j) == 0);
                    matrix.Set(0, i, j);

                }

            }
        }
    }
}
