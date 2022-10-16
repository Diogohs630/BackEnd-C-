using System;

namespace ExercicioProposto3Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vetA;
            int[] vetB;
            vetA = new int[N];
            vetB = new int[N];
            string[] A = Console.ReadLine().Split(' ');
            string[] B = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vetA[i] = int.Parse(A[i]);
            }
            for (int i = 0; i < N; i++)
            {
                vetB[i] = int.Parse(B[i]);
            }

            // Gerando o vetor C
            int[] vetC;
            vetC = new int[N];
            for (int i = 0; i < N; i++)
            {
                vetC[i] = vetA[i] + vetB[i];
            }
            // Imprimindo o vetor C
            for (int i = 0; i < N; i++)
            {
                Console.Write(vetC[i] + " ");
            }
            Console.ReadLine();
        }
    }
}