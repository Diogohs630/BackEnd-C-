using System;
using System.Globalization;

namespace Avaliacao3Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int contP = 0, contN = 0;
            for(int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    contP++;
                }
                else
                {
                    contN++;
                }
            }
            Console.WriteLine(contP + " in");
            Console.WriteLine(contN + " out");
            Console.ReadLine();
        }
    }
}