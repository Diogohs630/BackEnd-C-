using System;
using System.Globalization;

namespace ExercicioPropostoVetores1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            int N = int.Parse(Console.ReadLine());
            vet = new double[N];
            string[] s = Console.ReadLine().Split(' ');
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            // Localizar o maior numero do vetor
            double maior = vet[0];
            for (int i = 0; i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    cont = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(cont);

            Console.ReadLine();
        }
    }
}