using System;
using System.Globalization;

namespace Exercicio2Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            int N = int.Parse(Console.ReadLine());
            vet = new double[N];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            double media = 0.0;
            media += soma/N;
            Console.Write(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}