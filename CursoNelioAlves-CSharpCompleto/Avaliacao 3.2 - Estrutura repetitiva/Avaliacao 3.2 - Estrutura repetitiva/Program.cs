using System;

namespace Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cont1 = 0, cont2 = 0;
            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    cont1++;
                }
                else
                {
                    cont2++;
                }
            }
            Console.WriteLine(cont1 + " in");
            Console.WriteLine(cont2 + " out");
            Console.ReadLine();
        }
    }
}