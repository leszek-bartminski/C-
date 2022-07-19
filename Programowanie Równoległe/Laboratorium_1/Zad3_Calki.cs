using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad3_Calki
    {
        public void Zadanie()
        {
            double Value = 0;
           
            for (double x = 0; x < 2; x += 0.1) // Ilość elementów = 20 (przy x = 0.1, gdzie x - długość odcinka).
            {
                Value += 0.5 * x * 0.1;
            }

            Console.WriteLine(Value); // 1. Przy 20 elementach (2 / 0.1) dokładność to 0.95.
                                      // 2. (Do zadania 5) Jest to wariant obliczania wartości po lewej stronie wykresu, zaczynamy od x = 0.
                                      //Dla pierwszego odcinka o długości 0.1 na osi X nie ma prostokąta. Pierwszy jest na odcinku 0.1 - 0.2.
        }
    }
}
