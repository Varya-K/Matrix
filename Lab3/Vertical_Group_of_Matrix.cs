using Lab3.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Vertical_Group_of_Matrix:IMatrix
    {
        private Horizontal_Group_of_Matrix group_of_matrix;
        private Transposition_of_Matrix vertical_group_of_matrix;
        public Vertical_Group_of_Matrix()
        {
            group_of_matrix = new Horizontal_Group_of_Matrix();
            vertical_group_of_matrix = new Transposition_of_Matrix(group_of_matrix);
        }
        public void Add_Matrix(IMatrix matrix)
        {
            group_of_matrix.Add_Matrix(new Transposition_of_Matrix(matrix));
        }
        public void Set(double value, int row, int column)
        {
           vertical_group_of_matrix.Set(value, row, column);
        }
        public double Get(int row, int column)
        {
            return vertical_group_of_matrix.Get(row, column);
        }
        public int Row_Count { get => vertical_group_of_matrix.Row_Count; }
        public int Column_Count { get=> vertical_group_of_matrix.Column_Count; }

    }
}
