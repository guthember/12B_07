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

        }
    }
}
