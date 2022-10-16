using System;
using System.Globalization;

namespace BEE1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N  = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    double quadrado = Math.Pow(i, 2.0);
                    Console.WriteLine(i +"^"+"2" + " = " + quadrado.ToString("F0", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}