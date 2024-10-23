using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form_Panel_Matrix : Form
    {
        public Form_Panel_Matrix()
        {
            InitializeComponent();

        }
        public Graphics Get_G()
        {
            //panel1.Invalidate();
            return panel1.CreateGraphics(); ;
        }

    }
}
