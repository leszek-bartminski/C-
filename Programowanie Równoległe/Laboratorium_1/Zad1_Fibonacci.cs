using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad1_Fibonacci
    {



        public void Zadanie()
        {
            int numElement;
            Console.WriteLine("Podaj liczbę wyrazów ciągu: ");
            numElement = int.Parse(Console.ReadLine());
            int[] a = new int[numElement];
            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i < numElement; i++)
            {
                a[i] = a[i - 2] + a[i - 1];

            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }

        }

    }
}
