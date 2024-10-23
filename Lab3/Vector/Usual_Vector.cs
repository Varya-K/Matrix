using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Vector
{
    class Usual_Vector : IVector
    {
        private double[] vector;
        private int dimension;
        public Usual_Vector(int dimension)
        {
            this.dimension = dimension;
            vector = new double[dimension];
        }

        public void Set(double value, int position)
        {
            vector[position] = value;
        }
        public double Get(int position)
        {
            return vector[position];
        }
        public int Vector_Dimension { get { return dimension; } }
    }
}
