using System;
using System.Security.Cryptography.X509Certificates;

namespace BEE1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int contS = 0, contN = 0;
            int X;
            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    contS++;
                }
                else
                {
                    contN++;
                }
            }
            
            Console.WriteLine(contS + " in");
            Console.WriteLine(contN + " out");
            
            Console.ReadLine();
        }
    }
}