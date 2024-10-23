using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Drawer;

namespace Lab3.Matrix_Drawer
{
    class CellDrawerWithoutZero : ICellDrawer
    {
        public void DrawCell(int x, int y, double value, int cell_width, IDrawer drawer)
        {
            if (value != 0)
            {
                drawer.Draw_Text(x, y, value.ToString().Substring(0, Math.Min(value.ToString().Length, cell_width)));
            }
        }
    }
}
