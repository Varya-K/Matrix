using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix_Drawer
{
    class GridDrawer : ADrawerDecorator
    {
        public GridDrawer(IMatrixDrawer matrix_drawer) : base(matrix_drawer) { }
        public override void Draw(int x, int y, ICellDrawer cell_drawer)
        {
            base.Draw(x, y, cell_drawer);
            DrawGrid(x, y);
        }

        private void DrawGrid(int x, int y)
        {
            for (int i = 1; i < Row_Count; i++)
            {
                Draw_Line(false, x - 1, y + i * 2 - 1, Width + 2);
            }
            for (int i = 1; i < Column_Count; i++)
            {
                Draw_Line(true, x + (Cell_Width + 1) * i - 1, y - 1, Height + 2);
            }
        }
    }
}
