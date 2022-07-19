using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad7_Calki
    {
        public void Zadanie()
        {
            double a;
            double b;
            double Value = 0;

            for (double x = 0; x <= 2 * Math.PI; x += 0.001 * Math.PI)
            {
                a = Math.Sin(x);
                b = Math.Sin(x + 0.001 * Math.PI);

                Value += 0.5 * (a + b) * 0.001 * Math.PI;
            }
            decimal ValueDecimal = Convert.ToDecimal(Value); // Konwersja do typu decimal ze względu na postać wyniku double: 4,93479398216133E-06, która może nie być czytelna.
            Console.WriteLine(Math.Round(ValueDecimal, 10)); 
        }

    }
}
