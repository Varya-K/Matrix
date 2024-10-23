using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix_Drawer
{
    class BoardDrawer : ADrawerDecorator
    {
        public BoardDrawer(IMatrixDrawer matrix_drawer) : base(matrix_drawer) { }
        public override void Draw(int x, int y, ICellDrawer cell_drawer)
        {
            base.Draw(x + 1, y + 1, cell_drawer);
            DrawBoard(x, y);
        }
        private void DrawBoard(int x, int y)
        {
            Draw_Line(true, x, y, base.Height + 2);//Левая сторона
            Draw_Line(true, x + base.Width + 1, y, base.Height + 2);//Правая сторона
            Draw_Line(false, x, y, base.Width + 2);//Верхняя сторона
            Draw_Line(false, x, y + base.Height + 1, base.Width + 2);//Нижняя сторона
        }
        public override int Height => base.Height + 2;
        public override int Width => base.Width + 2;

    }
}
