using System;

namespace BEE1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if ((B % A == 0) || (A % B == 0))
            {
                Console.WriteLine("Sao Multiplos");
            } 
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadLine();
        }
    }
}