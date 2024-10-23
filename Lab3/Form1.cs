
using Lab3.Drawer;
using Lab3.Matrix;
using Lab3.Matrix_Drawer;
using System.CodeDom.Compiler;
using System.Data;
using System.Runtime.InteropServices;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            form_panel_matrix = new Form_Panel_Matrix();
            form_panel_matrix.Show();


            console_drawer = new Console_Drawer();
            form_drawer = new Form_Drawer(form_panel_matrix.Get_G());


            AllocConsole();


        }
        private Form_Panel_Matrix form_panel_matrix;
        private IMatrix matrix;
        private IMatrix matrix_original;
        private Console_Drawer console_drawer;
        private Form_Drawer form_drawer;
        private IMatrixDrawer matrix_drawer_console;
        private IMatrixDrawer matrix_drawer_form;
        private ICellDrawer cellDrawer;

        private int matrix_size = 5;
        private int count_non_zero = 20;
        private int max_value = 100;
        private void b_Generation_Usual_Click(object sender, EventArgs e)
        {
            Generate_Matrix(true);
        }
        private void b_Generation_Sparse_Click(object sender, EventArgs e)
        {
            Generate_Matrix(false);
        }

        private void Generate_Matrix(bool usual)
        {
            if (usual) 
            {
                matrix = new Usual_Matrix(matrix_size, matrix_size);
                cellDrawer = new CellDrawerWithZero();
            }
            else
            {
                matrix = new Sparse_Matrix(matrix_size, matrix_size);
                cellDrawer = new CellDrawerWithoutZero();
            }
            matrix_original = matrix;
            Matrix_Initiator.Fill_Matrix(matrix, count_non_zero, max_value);
            Redraw();
        }

        

        private void cÂ_Draw_Board_CheckedChanged(object sender, EventArgs e)
        {
            Redraw();
        }
        private void Redraw()
        {
            form_drawer.g=form_panel_matrix.Get_G();
            form_drawer.g.Clear(BackColor);
            Console.Clear();
            if (matrix != null)
            {
                matrix_drawer_console = new MatrixDrawer(matrix, console_drawer);
                matrix_drawer_form = new MatrixDrawer(matrix, form_drawer);
                if (cB_Draw_Grid.Checked)
                {
                    matrix_drawer_console = new GridDrawer(matrix_drawer_console);
                    matrix_drawer_form = new GridDrawer(matrix_drawer_form);
                }
                if (cÂ_Draw_Board.Checked)
                {
                    matrix_drawer_console = new BoardDrawer(matrix_drawer_console);
                    matrix_drawer_form = new BoardDrawer(matrix_drawer_form);
                }
                matrix_drawer_console.Draw(0, 0, cellDrawer);
                matrix_drawer_form.Draw(0, 0, cellDrawer);
            }
        }

        private void cB_Draw_Grid_CheckedChanged(object sender, EventArgs e)
        {
            Redraw();
        }

        private void b_Renumbering_Click(object sender, EventArgs e)
        {
            Renumbering_Decorator matrix1;
            if (matrix is Renumbering_Decorator) matrix1 = (Renumbering_Decorator)matrix;
            else matrix1 = new Renumbering_Decorator(matrix);

            int row1, row2, col1, col2;
            Random rand = new Random();
            row1 = rand.Next(matrix.Row_Count);
            do
            {
                row2 = rand.Next(matrix.Row_Count);
            } while (row2 == row1);
            col1 = rand.Next(matrix.Column_Count);
            do
            {
                col2 = rand.Next(matrix.Column_Count);
            } while (col2 == col1);
            matrix1.Swap_Rows(row1, row2);
            matrix1.Swap_Columns(col1, col2);
            matrix = matrix1;
            Redraw();
        }

        private void b_Return_Click(object sender, EventArgs e)
        {
            matrix = matrix_original;
            Redraw();
        }

        private void b_Group_Usual_Click(object sender, EventArgs e)
        {
            Generate_Group_of_Matrix(true);
        }

        private void b_Group_Sparse_Click(object sender, EventArgs e)
        {
            Generate_Group_of_Matrix(false);
        }

        private void Generate_Group_of_Matrix(bool usual)
        {
            var matrix1 = new Vertical_Group_of_Matrix();
            Random rnd = new Random();
            int count1 = rnd.Next(3, 5);
            int number = 1;
            for (int i = 0; i < count1; i++)
            {
                int group_or_matrix = rnd.Next(2);
                IMatrix matrix2;
                if (group_or_matrix == 0)
                {
                    int count2 = rnd.Next(2, 4);
                    var group_of_matrix = new Horizontal_Group_of_Matrix();
                    for(int j = 0; j < count2; j++)
                    {
                        group_of_matrix.Add_Matrix(Generate_Random_Matrix(usual, number));
                        number++;
                    }
                    matrix2 = group_of_matrix;
                }
                else
                {
                    matrix2 = Generate_Random_Matrix(usual, number);
                    number++;
                }
                matrix1.Add_Matrix(matrix2);
            }
            matrix = matrix1;
            matrix_original = matrix;
            if(usual) cellDrawer = new CellDrawerWithZero();
            else cellDrawer = new CellDrawerWithoutZero();
            Redraw();
        }

        private IMatrix Generate_Random_Matrix(bool usual, int number)
        {
            Random rnd = new Random();
            int row_count = rnd.Next(1, 5);
            int column_count = rnd.Next(1, 5);
            IMatrix matrix;
            if (usual) matrix = new Usual_Matrix(row_count,column_count);
            else matrix = new Sparse_Matrix(row_count,column_count);
            if(number==0) Matrix_Initiator.Fill_Matrix(matrix, rnd.Next(row_count*column_count/4,row_count*column_count*3/4), max_value);
            else
            {
                for(int row = 0; row < row_count; row++)
                {
                    for(int col=0;col<column_count; col++)
                    {
                        matrix.Set(number, row, col);
                    }
                }
            }
            return matrix;
        }

       

        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        
    }
}