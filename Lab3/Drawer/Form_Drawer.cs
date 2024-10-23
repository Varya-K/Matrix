using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Drawer
{
    public class Form_Drawer : IDrawer
    {
        private int sign_height, sign_width;
        public Graphics g { get; set; }
        private Font font;
        private SolidBrush brush = new SolidBrush(Color.Black);
        public Form_Drawer(Graphics g, int sign_width=8)
        {
            this.sign_width = sign_width;
            font = new Font("Arial", sign_width);
            sign_height = font.Height;
            this.g = g;
        }

        public void Draw_Line(bool vertical, int x, int y, int length)
        {

            Pen pen = new Pen(Color.Black, 2);
            if (vertical)
            {
                g.DrawLine(pen, x * sign_width + sign_width / 2, y * sign_height + sign_height / 2, x * sign_width + sign_width / 2, (y - 1 + length) * sign_height + sign_height / 2);
            }
            else
            {
                g.DrawLine(pen, x * sign_width + sign_width / 2, y * sign_height + sign_height / 2, (x - 1 + length) * sign_width + sign_width / 2, y * sign_height + sign_height / 2);
            }
        }
        public void Draw_Text(int x, int y, string text)
        {
            g.DrawString(text, font, brush, new Point(x * sign_width, y * sign_height));
        }
    }
}
