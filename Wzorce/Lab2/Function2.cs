using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Function2 : IFunction
    {
        public int Id => 2;

        public string Name => "2x\xB2";

        public double GetY(double x)
        {
            return 2*x*x;
        }
    }
}
