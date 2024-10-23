namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b_Generation_Usual = new Button();
            b_Generation_Sparse = new Button();
            cВ_Draw_Board = new CheckBox();
            cB_Draw_Grid = new CheckBox();
            b_Renumbering = new Button();
            b_Return = new Button();
            b_Group_Usual = new Button();
            b_Group_Sparse = new Button();
            SuspendLayout();
            // 
            // b_Generation_Usual
            // 
            b_Generation_Usual.Location = new Point(12, 12);
            b_Generation_Usual.Name = "b_Generation_Usual";
            b_Generation_Usual.Size = new Size(261, 29);
            b_Generation_Usual.TabIndex = 0;
            b_Generation_Usual.Text = "Генерация обычной матрицы";
            b_Generation_Usual.UseVisualStyleBackColor = true;
            b_Generation_Usual.Click += b_Generation_Usual_Click;
            // 
            // b_Generation_Sparse
            // 
            b_Generation_Sparse.Location = new Point(12, 47);
            b_Generation_Sparse.Name = "b_Generation_Sparse";
            b_Generation_Sparse.Size = new Size(261, 29);
            b_Generation_Sparse.TabIndex = 1;
            b_Generation_Sparse.Text = "Генерация разряженой матрицы";
            b_Generation_Sparse.UseVisualStyleBackColor = true;
            b_Generation_Sparse.Click += b_Generation_Sparse_Click;
            // 
            // cВ_Draw_Board
            // 
            cВ_Draw_Board.AutoSize = true;
            cВ_Draw_Board.Location = new Point(12, 259);
            cВ_Draw_Board.Name = "cВ_Draw_Board";
            cВ_Draw_Board.Size = new Size(244, 24);
            cВ_Draw_Board.TabIndex = 2;
            cВ_Draw_Board.Text = "Отображать границу матрицы";
            cВ_Draw_Board.UseVisualStyleBackColor = true;
            cВ_Draw_Board.CheckedChanged += cВ_Draw_Board_CheckedChanged;
            // 
            // cB_Draw_Grid
            // 
            cB_Draw_Grid.AutoSize = true;
            cB_Draw_Grid.Location = new Point(12, 289);
            cB_Draw_Grid.Name = "cB_Draw_Grid";
            cB_Draw_Grid.Size = new Size(155, 24);
            cB_Draw_Grid.TabIndex = 4;
            cB_Draw_Grid.Text = "Отображать сетку";
            cB_Draw_Grid.UseVisualStyleBackColor = true;
            cB_Draw_Grid.CheckedChanged += cB_Draw_Grid_CheckedChanged;
            // 
            // b_Renumbering
            // 
            b_Renumbering.Location = new Point(12, 82);
            b_Renumbering.Name = "b_Renumbering";
            b_Renumbering.Size = new Size(261, 29);
            b_Renumbering.TabIndex = 5;
            b_Renumbering.Text = "Перенумеровать";
            b_Renumbering.UseVisualStyleBackColor = true;
            b_Renumbering.Click += b_Renumbering_Click;
            // 
            // b_Return
            // 
            b_Return.Location = new Point(12, 117);
            b_Return.Name = "b_Return";
            b_Return.Size = new Size(261, 29);
            b_Return.TabIndex = 6;
            b_Return.Text = "Восстановить";
            b_Return.UseVisualStyleBackColor = true;
            b_Return.Click += b_Return_Click;
            // 
            // b_Group_Usual
            // 
            b_Group_Usual.Location = new Point(12, 151);
            b_Group_Usual.Name = "b_Group_Usual";
            b_Group_Usual.Size = new Size(261, 48);
            b_Group_Usual.TabIndex = 7;
            b_Group_Usual.Text = "Генерация группы обычных матриц";
            b_Group_Usual.UseVisualStyleBackColor = true;
            b_Group_Usual.Click += b_Group_Usual_Click;
            // 
            // b_Group_Sparse
            // 
            b_Group_Sparse.Location = new Point(12, 205);
            b_Group_Sparse.Name = "b_Group_Sparse";
            b_Group_Sparse.Size = new Size(261, 48);
            b_Group_Sparse.TabIndex = 8;
            b_Group_Sparse.Text = "Генерация группы разряженных матриц";
            b_Group_Sparse.UseVisualStyleBackColor = true;
            b_Group_Sparse.Click += b_Group_Sparse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 323);
            Controls.Add(b_Group_Sparse);
            Controls.Add(b_Group_Usual);
            Controls.Add(b_Return);
            Controls.Add(b_Renumbering);
            Controls.Add(cB_Draw_Grid);
            Controls.Add(cВ_Draw_Board);
            Controls.Add(b_Generation_Sparse);
            Controls.Add(b_Generation_Usual);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Generation_Usual;
        private Button b_Generation_Sparse;
        private CheckBox cВ_Draw_Board;
        private CheckBox cB_Draw_Grid;
        private Button b_Renumbering;
        private Button b_Return;
        private Button b_Group_Usual;
        private Button b_Group_Sparse;
    }
}