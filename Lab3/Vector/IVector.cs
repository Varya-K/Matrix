using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Vector
{
    interface IVector
    {
        void Set(double value, int position);
        double Get(int position);
        int Vector_Dimension { get; }

    }
}
