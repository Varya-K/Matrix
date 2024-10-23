using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Drawer
{
    internal interface IDrawer
    {
        void Draw_Line(bool vertical, int x, int y, int length);
        void Draw_Text(int x, int y, string text);
    }
}
