using System;
using System.Data;
using System.Data.Common;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            int j, n;

            Console.Write("\n\n");
            Console.Write("Napisz tabliczkę mnożenia :\n");
            Console.Write("\n\n");

            Console.Write("Wpisz liczbę : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }
    }
}