using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Vector;

namespace Lab3.Matrix
{
    abstract class ASome_Matrix : IMatrix
    {
        private IVector[] matrix;
        private int row_count, column_count;
        protected ASome_Matrix(int row_count, int column_count)
        {
            matrix = new IVector[row_count];
            this.row_count = row_count;
            this.column_count = column_count;
            for (int i = 0; i < row_count; i++)
            {
                matrix[i] = Make_Vector(column_count);
            }
        }
        protected abstract IVector Make_Vector(int column_count);
        public void Set(double value, int row, int column)
        {
            matrix[row].Set(value, column);
        }
        public double Get(int row, int column)
        {
            return matrix[row].Get(column);
        }
        public int Row_Count { get { return row_count; } }
        public int Column_Count { get { return column_count; } }

    }
}
