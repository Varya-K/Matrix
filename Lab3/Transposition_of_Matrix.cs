using Lab3.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Transposition_of_Matrix:IMatrix
    {
        private IMatrix matrix;
        public Transposition_of_Matrix(IMatrix matrix)
        {
            this.matrix = matrix;
        }
        public void Set(double value, int row, int column)
        {
            matrix.Set(value, column,row);
        }
        public double Get(int row, int column)
        {
            return matrix.Get(column, row);
        }
        public int Row_Count { get => matrix.Column_Count; }
        public int Column_Count { get => matrix.Row_Count; }
    }
}
