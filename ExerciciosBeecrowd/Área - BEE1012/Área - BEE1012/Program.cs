using System;
using System.Globalization;

namespace BEE1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi = 3.14159;
            String line1 = Console.ReadLine();

            String[] vet = line1.Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture); 

            Console.WriteLine("TRIANGULO: " + ((A * C)/2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (pi * Math.Pow(C, 2.00)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + (((A + B)*C) / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (Math.Pow(B, 2.0).ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}