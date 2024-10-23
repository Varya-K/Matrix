using Lab3.Drawer;
using Lab3.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix_Drawer
{

    class MatrixDrawer : IMatrixDrawer
    {
        private IMatrix matrix;
        private IDrawer drawer;
        public MatrixDrawer(IMatrix matrix, IDrawer drawer)
        {
            this.matrix = matrix;
            this.drawer = drawer;
            Cell_Width = 5;
        }

        public void Draw(int x, int y, ICellDrawer cell_drawer)
        {
            for (int row = 0; row < matrix.Row_Count; row++)
            {
                for (int col = 0; col < matrix.Column_Count; col++)
                {
                    cell_drawer.DrawCell(x + col * (Cell_Width + 1), y + row * 2, matrix.Get(row, col), Cell_Width, drawer);
                }
            }
        }

        public int Row_Count { get { return matrix.Row_Count; } }
        public int Column_Count { get { return matrix.Column_Count; } }
        public int Cell_Width { get; set; }
        public int Height { get { return Row_Count * 2 - 1; } }
        public int Width { get { return Column_Count * (Cell_Width + 1) - 1; } }
        public void Draw_Line(bool vertical, int x, int y, int length)
        {
            drawer.Draw_Line(vertical, x, y, length);
        }
        public void Draw_Text(int x, int y, string text)
        {
            drawer.Draw_Text(x, y, text);
        }
    }
}
