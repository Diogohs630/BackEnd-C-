using System;
using System.Globalization;

namespace BEE1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int valor = 0, divisor = 0;
            double divisao = 0.0;
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                valor = int.Parse(vet[0]);
                divisor = int.Parse(vet[1]);

                if (divisor == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = (double) valor / divisor;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
            Console.ReadLine();
        }
    }
}