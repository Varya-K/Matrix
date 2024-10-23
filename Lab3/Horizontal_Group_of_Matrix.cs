using Lab3.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Horizontal_Group_of_Matrix:IMatrix
    {
        private List<IMatrix> matrix_group;
        public Horizontal_Group_of_Matrix()
        {
            matrix_group = new List<IMatrix>();
        }
        public void Add_Matrix(IMatrix matrix)
        {
            matrix_group.Add(matrix);
        }
        public int Row_Count
        {
            get
            {
                int max = 0;
                foreach(var matrix in matrix_group)
                {
                    if(max<matrix.Row_Count) max= matrix.Row_Count;
                }
                return max;
            }
        }
        public int Column_Count
        {
            get
            {
                int sum = 0;
                foreach (var matrix in matrix_group)
                {
                    sum += matrix.Column_Count;
                }
                return sum;
            }
        }

        public void Set(double value, int row, int column)
        {
            foreach(var matrix in matrix_group)
            {
                if (column < matrix.Column_Count)
                {
                    if(row < matrix.Row_Count) 
                        matrix.Set(value, row, column);
                }
                else
                {
                    column-=matrix.Column_Count;
                }
            }
        }
        public double Get(int row, int column)
        {
            foreach (var matrix in matrix_group)
            {
                if (column < matrix.Column_Count)
                {
                    if (row < matrix.Row_Count)
                        return matrix.Get(row, column);
                    else return 0;
                }
                else
                {
                    column -= matrix.Column_Count;
                }
            }
            return 0;
        }

        
    }
}
