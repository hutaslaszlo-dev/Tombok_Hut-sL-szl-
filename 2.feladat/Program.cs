using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A heti hőmérsékletek:");

            int[] homersekletek = {12,8,-1,5,14,7,2};
            for (int i = 0; i < homersekletek.Length; i++)
            {
 
            }
            Console.WriteLine(String.Join(" ", homersekletek));

            Array.Sort(homersekletek);
            Array.Reverse(homersekletek);
            Console.WriteLine();
            Console.WriteLine($"A Legalacsonyabb hőmérséklet: {homersekletek[6]} C");
            Console.WriteLine($"Legmagasabb hőmérséklet: {homersekletek[0]} C");
            Console.WriteLine($"A heti átlaghőmérséklet: {(homersekletek[6] + homersekletek[5] + homersekletek[4] + homersekletek[3] + homersekletek[2] + homersekletek[1] + homersekletek[0]) / 7} C");




            Console.ReadKey();
        }
    }
}
