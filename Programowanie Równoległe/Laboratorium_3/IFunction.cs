using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    interface IFunction
    {
        int Id { get; }

        string Name { get;}

        double GetY(double x);
    }
}
