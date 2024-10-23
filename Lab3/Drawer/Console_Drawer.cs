using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Drawer
{
    class Console_Drawer : IDrawer
    {
        public void Draw_Line(bool vertical, int x, int y, int length)
        {
            if (vertical)
            {
                for (int i = y; i < y + length; i++)
                {
                    Console.SetCursorPosition(Math.Max(x, 0), Math.Max(i, 0));
                    Console.Write('|');
                }
            }
            else
            {
                for (int i = x; i < x + length; i++)
                {
                    Console.SetCursorPosition(Math.Max(i, 0), Math.Max(y, 0));
                    Console.Write('-');
                }
            }
        }
        public void Draw_Text(int x, int y, string text)
        {
            Console.SetCursorPosition(Math.Max(x, 0), Math.Max(y, 0));
            Console.Write(text);
        }
    }
}
