using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    class Zad2_Fibonacci
    {
        public void Zadanie()
        {
            int firstElement, numElements;
            Console.WriteLine("Podaj L1 ");
            firstElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj L2 ");
            numElements = int.Parse(Console.ReadLine());

            int n = firstElement + numElements - 1;

            int[] a = new int[n];
            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i < n; i++)
            {
                a[i] = a[i - 2] + a[i - 1];

            }

            for (int j = a[firstElement]; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
    }
}
