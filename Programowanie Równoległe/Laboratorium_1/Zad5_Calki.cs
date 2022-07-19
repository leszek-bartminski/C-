using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad5_Calki
    {
        public void Zadanie()
        {
            // Wyznaczanie wartości funkcji dla środka prostokąta:
            double ValueMiddle = 0;            
            for (double x = 0.05; x < 2; x += 0.1) // x inicjuję od 0.05, jest to wartość f(x) dla x = 0.05 - pośrodku prostokąta.
            {
                ValueMiddle += 0.5 * x * 0.1;
            }
            // Dokładność w przypadku tej funkcji metodą wartości funkcji dla środka prostokąta wynosi 100%.
            Console.WriteLine($"Wartość całki wyznaczona z wartości funkcji dla środka prostokąta: {ValueMiddle}");


            // Wyznaczanie wartości funkcji dla lewej strony  prostokąta:
            double ValueLeft = 0;
            for (double x = 0; x < 2; x += 0.1) // Ilość elementów = 20 (przy x = 0.1, gdzie x - długość odcinka).
            {
                ValueLeft += 0.5 * x * 0.1;
            }
            // Dokładność w przypadku tego sposobu wynosi 95%.
            Console.WriteLine($"Wartość całki wyznaczona z wartości funkcji dla lewej strony prostokąta: {ValueLeft}");


            // Wyznaczanie wartości funkcji dla prawej strony  prostokąta:
            double ValueRight = 0;
            for (double x = 0.1; x < 2; x += 0.1) // x inicjuję od 0.1, jest to wartość f(x) dla x = 0.1 - po prawej stronie prostokąta.
            {
                ValueRight += 0.5 * x * 0.1;
            }
            // Dokładność w przypadku tego sposobu jest równa sposobowi lewej strony prostokąta i wynosi 95%.
            Console.WriteLine($"Wartość całki wyznaczona z wartości funkcji dla prawej strony prostokąta: {ValueRight}");
        }
    }
}
