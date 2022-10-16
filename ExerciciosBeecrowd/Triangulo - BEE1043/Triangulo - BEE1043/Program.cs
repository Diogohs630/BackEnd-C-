using System;
using System.Globalization;

namespace BEE1034
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            if ((A + B) > C && (A + C) > B && (B + C) > A)
            {
                double Perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + Perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double Area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + Area.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
