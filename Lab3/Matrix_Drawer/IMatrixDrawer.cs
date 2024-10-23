using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix_Drawer
{
    interface IMatrixDrawer
    {
        void Draw(int x, int y, ICellDrawer cell_drawer);
        int Row_Count { get; }
        int Cell_Width { get; set; }
        int Height { get; }
        int Width { get; }
        int Column_Count { get; }
        void Draw_Line(bool vertical, int x, int y, int length);
        void Draw_Text(int x, int y, string text);

    }
}
