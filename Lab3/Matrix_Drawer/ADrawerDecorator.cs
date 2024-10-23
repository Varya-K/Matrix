using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix_Drawer
{
    abstract class ADrawerDecorator : IMatrixDrawer
    {
        private IMatrixDrawer matrix_drawer;
        protected ADrawerDecorator(IMatrixDrawer matrix_drawer)
        {
            this.matrix_drawer = matrix_drawer;
        }
        public virtual void Draw(int x, int y, ICellDrawer cell_drawer)
        {
            matrix_drawer.Draw(x, y, cell_drawer);
        }
        public int Row_Count { get { return matrix_drawer.Row_Count; } }
        public int Column_Count { get { return matrix_drawer.Column_Count; } }
        public int Cell_Width { get { return matrix_drawer.Cell_Width; } set { matrix_drawer.Cell_Width = value; } }
        public virtual int Height { get { return matrix_drawer.Height; } }
        public virtual int Width { get { return matrix_drawer.Width; } }
        public void Draw_Line(bool vertical, int x, int y, int length)
        {
            matrix_drawer.Draw_Line(vertical, x, y, length);
        }
        public void Draw_Text(int x, int y, string text)
        {
            matrix_drawer.Draw_Text(x, y, text);
        }


    }
}
