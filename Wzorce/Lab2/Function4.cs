using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    // dodanie nowej instancji klasy, pierwsze (z czterech) miejsce zmiany w kodzie:  
    class Function4 : IFunction
    {
        public int Id => 4;

        public string Name => "3x\xB2 + 2x + 3";

        public double GetY(double x)
        {
            return 3*x*x + 2*x +3;
        }
    }
}
