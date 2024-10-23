using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Drawer;

namespace Lab3.Matrix_Drawer
{
    interface ICellDrawer
    {
        void DrawCell(int x, int y, double value, int cell_width, IDrawer drawer);

    }
}
