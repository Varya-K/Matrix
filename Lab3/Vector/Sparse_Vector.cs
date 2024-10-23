using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Vector
{
    class Sparse_Vector : IVector
    {
        private Dictionary<int, double> vector;
        private int dimension;
        public Sparse_Vector(int dimension)
        {
            this.dimension = dimension;
            vector = new Dictionary<int, double>();
        }

        public void Set(double value, int position)
        {
            if(value==0) vector.Remove(position);
            else vector[position] = value;
        }
        public double Get(int position)
        {
            double value;
            if (vector.TryGetValue(position, out value))
                return value;
            else return 0;
        }
        public int Vector_Dimension { get { return dimension; } }
    }
}
