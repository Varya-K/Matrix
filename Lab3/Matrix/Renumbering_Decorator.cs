using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix
{
    class Renumbering_Decorator : IMatrix
    {
        private IMatrix matrix;
        private int[] row_order;
        private int[] column_order;
        public Renumbering_Decorator(IMatrix matrix)
        {
            this.matrix = matrix;
            row_order = new int[matrix.Row_Count];
            column_order = new int[matrix.Column_Count];
            for (int i = 0; i < matrix.Row_Count; i++)
            {
                row_order[i] = i;
            }
            for (int i = 0; i < matrix.Column_Count; i++)
            {
                column_order[i] = i;
            }
        }
        public void Set(double value, int row, int column)
        {
            matrix.Set(value, row_order[row], column_order[column]);
        }
        public double Get(int row, int column)
        {
            return matrix.Get(row_order[row], column_order[column]);
        }
        public int Row_Count { get => matrix.Row_Count; }
        public int Column_Count { get => matrix.Column_Count; }

        public void Swap_Rows(int row1, int row2)
        {
            int t = row_order[row1];
            row_order[row1] = row_order[row2];
            row_order[row2] = t;
        }
        public void Swap_Columns(int col1, int col2)
        {
            int t = column_order[col1];
            column_order[col1] = column_order[col2];
            column_order[col2] = t;
        }

    }
}
