using System;
using System.Globalization;

namespace ExercicioProposto4Vetores
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
            double media = 0;
            for (int i = 0; i < N; i++)
            {
                media += vet[i] / N;
            }
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}