using System;

namespace BEE1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (i % N == 2)
                {
                    soma = i;
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}