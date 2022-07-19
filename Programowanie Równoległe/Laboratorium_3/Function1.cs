using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Function1 : IFunction
    {
        public int Id => 1;

        public string Name => "2x + 2x\xB2";

        public double GetY(double x)
        {
            return 2*x + 2*x*x;
        }
    }
}