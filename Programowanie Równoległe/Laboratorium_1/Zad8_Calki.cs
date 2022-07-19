using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad8_Calki
    {
        public void Zadanie()
        {
            Console.WriteLine("Podaj parametr a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj parametr b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj parametr c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wartość x dla dolnej granicy całkowania: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wartość x dla górnej granicy całkowania: ");
            double x2 = double.Parse(Console.ReadLine());

            double Value = 0;
            double a1;
            double b1;
            double h = 0.001;
            for (double x = x1; x < x2; x += h)
            {
                a1 = a * x * x + b * x + c;
                b1 = a * (x + h) * (x + h) + b * (x + h) + c;

                Value += 0.5 * (a1 + b1) * h;
            }

            decimal ValueDecimal = Convert.ToDecimal(Value);
            Console.WriteLine(Math.Round(ValueDecimal, 9));
        }
    }
}
