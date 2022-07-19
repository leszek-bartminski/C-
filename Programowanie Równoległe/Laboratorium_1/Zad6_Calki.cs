using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad6_Calki
    {
        public void Zadanie()
        {
            double a;
            double b;
            double Value = 0;
            for (double x = 0; x < 2; x += 0.1)
            {
                a = 0.5 * x; // Wartość funkcji dla lewej strony odcinka to długość krótszej podstawy trapezu.
                b = 0.5 * (x + 0.1); // Wartość dla x większego o 0.1 (prawa strona odcinka) to długość dłuższej podstawy trapezu.

                Value += 0.5 * (a + b) * 0.1; // W każdej iteracji wartość zmiennej Value jest inkrementowana o pole trapezu - 0.5*(a+b)*h,
                                              // gdzie h jest niezmienne i wynosi za każdym razem 0.1, tyle co długość odcinka. Zmieniają się tylko
                                              // podstawy trapezów.
            }
            Console.WriteLine(Value); //Wartość całki wynosi 1, dokładność metodą trapezów w przypadku tej funkcji to 100%.
        }
    }
}
