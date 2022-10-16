using System;

namespace BEE1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet;
            int cont = 0;
            int N  = int.Parse(Console.ReadLine());
            vet = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    cont++;
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
            Console.ReadLine();
        }
    }
}