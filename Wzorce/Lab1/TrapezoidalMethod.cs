using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class TrapezoidalMethod : ICalculator
    {
        public string Name => "Metoda trapezów: ";

        public double GetIntegralValue(IFunction function, Range range, ILanguage language)
        {
            Console.WriteLine(language.Translation["obliczanie_calki_metoda_trapezow"]);            

            double Value = 0;
            for (double i = range.rangeFrom; i <= range.rangeTo; i += 0.001)
            {
                Value += (function.GetY(i) + function.GetY(i + 0.001)) * 0.001 / 2;
            }

            Console.WriteLine("{0} {1}", language.Translation["calka_metoda_trapezow_to"], Value);
            return Value;
        }
    }
}
