using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Vector;

namespace Lab3.Matrix
{
    class Usual_Matrix : ASome_Matrix
    {
        public Usual_Matrix(int row_count, int column_count) : base(row_count, column_count) { }
        protected override IVector Make_Vector(int column_count)
        {
            return new Usual_Vector(column_count);
        }

    }
}
