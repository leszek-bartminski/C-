using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad4_Calki
    {
        public void Zadanie()
        {
            double Value = 0;
            double krok = 0.01;
            for (double x = 0; x < 2; x += krok) // Ilość elementów = 200 (przy x = 0.01, gdzie x - długość odcinka).
            {
                Value += 0.5 * x * krok;
            }

            Console.WriteLine(Value); // Przy 200 elementach (2 / 0.1) dokładność to 0,995000000000001.
        }
    }
}
