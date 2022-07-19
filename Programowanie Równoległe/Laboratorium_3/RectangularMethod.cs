using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class RectangularMethod : ICalculator
    {
        public string Name => "Metoda kwadratów";

        public double GetIntegralValue(IFunction function, Range range, ILanguage language)
        {
            Console.WriteLine(language.Translation["obliczanie_calki_metoda_kwadratow"]);
            
            double Value = 0;
            for (double i = range.rangeFrom; i <= range.rangeTo; i += 0.001)
            {
                Value += function.GetY(i) * 0.001;
            }

            Console.WriteLine("{0} {1}", language.Translation["calka_metoda_kwadratow_to"], Value);
            return Value;
        }
    }
}
