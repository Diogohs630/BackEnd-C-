using System;
using System.Globalization;

namespace BEE1037
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //([0, 25], (25, 50], (50, 75], (75, 100])
            if (X >= 0.00 && X <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (X > 25.00 && X <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (X > 50.00 && X <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (X > 75.00 && X <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.ReadLine();
        }
    }
}