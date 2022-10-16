using System;
using System.Globalization;

namespace ExercicioProposto5Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet;
            int N = int.Parse(Console.ReadLine());
            vet = new int[N];
            int cont = 0, soma = 0;
            double media = 0.0;
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);    
            }
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    soma += vet[i];
                    cont++;
                    media = soma / cont;
                }
            }
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}