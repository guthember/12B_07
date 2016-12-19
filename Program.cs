using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SzamokTomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[5];

            Console.WriteLine("Kérek 5 darab számot.");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}. szam:",i+1);
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }

            int osszeg = 0, min = 0, max = 0;

            min = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                // maximumkeresés
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                // minimumkeresés
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
                // összegképzés
                osszeg += tomb[i];
            }

            Console.WriteLine("Az osszeg: {0}",osszeg);
            Console.WriteLine("Minimum: {0}",min);
            Console.WriteLine("Maximum: {0}",max);

            Console.ReadKey();
        }
    }
}
