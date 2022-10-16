using System;
using System.Globalization;

namespace Avaliacao2Parte2
{
    class program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] vet = Console.ReadLine().Split(" ");
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = (Math.Pow(b, 2.0) - 4 * a * c);
            double x1 = 0, x2 = 0;
            if (a > 0 && delta >= 0)
            {
                x1 = ((-b) + Math.Sqrt(delta))/(2*a);
                x2 = ((-b) - Math.Sqrt(delta))/(2*a);
                Console.WriteLine("X1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}