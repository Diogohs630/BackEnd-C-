using System;

namespace ExercicioProposto6Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetNome;
            int[] vetIdade;
            int N = int.Parse(Console.ReadLine());
            vetNome = new string[N];
            vetIdade = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                vetNome[i] = s[0];
                vetIdade[i] = int.Parse(s[1]);
            }
            int maior = vetIdade[0];
            int cont = 0;
            for (int i = 1; i < N; i++)
            {
                if (vetIdade[i] > maior)
                {
                    maior = vetIdade[i];
                    cont = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + vetNome[cont]);
            Console.ReadLine();
        }
    }
}