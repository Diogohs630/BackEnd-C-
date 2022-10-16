using System;

namespace RepeticaoEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int soma = 0;
            while (X != 0)
            {
                soma += X;
                X = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}