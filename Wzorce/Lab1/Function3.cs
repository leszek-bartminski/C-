using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Function3 : IFunction
    {
        public int Id => 3;

        public string Name => "2x - 3";

        public double GetY(double x)
        {
            return 2*x - 3;
        }
    }
}