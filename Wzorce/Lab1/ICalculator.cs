using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    interface ICalculator
    {
        string Name { get; }
        public double GetIntegralValue(IFunction function, Range range, ILanguage language); 
    }
}
