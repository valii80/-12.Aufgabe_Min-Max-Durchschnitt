using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Aufgabe_Min_Max_Durchschnitt.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int min, max, summe = 0;

                Console.Write("Zahl 1: ");
                int zahl = int.Parse(Console.ReadLine());
                min = max = zahl;
                summe += zahl;

                for (int i = 2; i <= 5; i++)
                {
                    Console.Write($"Zahl {i}: ");
                    zahl = int.Parse(Console.ReadLine());

                    if (zahl < min) min = zahl;
                    if (zahl > max) max = zahl;

                    summe += zahl;
                }

                double durchschnitt = summe / 5.0;

                Console.WriteLine($"Min: {min}, Max: {max}, Durchschnitt: {durchschnitt}");
            }
        }

    }
}
