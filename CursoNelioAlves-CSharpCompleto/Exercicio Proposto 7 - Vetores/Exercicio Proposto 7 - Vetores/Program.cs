using System;
using System.Globalization;

namespace ExercicioProposto7Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetNome;
            double[] vetNotas1;
            double[] vetNotas2;
            int N = int.Parse(Console.ReadLine());
            vetNome = new string[N];
            vetNotas1 = new double[N];
            vetNotas2= new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                vetNome[i] = s[0];
                vetNotas1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                vetNotas2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Alunos aprovados:");
            double somaNotas = 0.0, media = 0.0;
            for (int i = 0; i < N; i++)
            {
                somaNotas = (vetNotas1[i] + vetNotas2[i]) / 2;
                if (somaNotas >= 6.0)
                {
                    Console.WriteLine(vetNome[i]);
                }
            }
            Console.ReadLine();
        }
    }
}