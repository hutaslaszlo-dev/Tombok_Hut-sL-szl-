using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A tömb elemei: ");

            int[] szamok = new int[10];
            Random random = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1, 100);
            }
            Console.WriteLine(String.Join(" ", szamok));

            Console.WriteLine($"A páros számok: {szamok / 2 = 0}");
            Console.WriteLine($"A negatív számok: {szamok / 2 = 1}");
            



            Console.ReadKey();
        }
    }
}
