using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Drawer;

namespace Lab3.Matrix_Drawer
{
    class CellDrawerWithZero : ICellDrawer
    {
        public void DrawCell(int x, int y, double value, int cell_width, IDrawer drawer)
        {
            drawer.Draw_Text(x, y, value.ToString().Substring(0, Math.Min(value.ToString().Length, cell_width)));
        }
    }
}
