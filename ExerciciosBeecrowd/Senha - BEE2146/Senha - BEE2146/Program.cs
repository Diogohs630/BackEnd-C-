using System;

namespace BEE2146
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());
            int n = senha;
            while (n == senha)
            {
                Console.WriteLine(senha - 1);
                break;
            }
            Console.ReadLine();
        }
    }
}