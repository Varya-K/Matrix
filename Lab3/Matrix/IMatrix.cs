using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Matrix
{
    interface IMatrix
    {
        void Set(double value, int row, int column);
        double Get(int row, int column);
        int Row_Count { get; }
        int Column_Count { get; }

    }
}
