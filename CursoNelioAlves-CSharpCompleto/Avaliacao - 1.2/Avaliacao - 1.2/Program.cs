using System;
using System.Globalization;

namespace Avaliacao1Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Raio;
            double pi = 3.14159;
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaCirculo = pi * Math.Pow(Raio, 2.0);
            Console.WriteLine("A=" + AreaCirculo.ToString("F4", CultureInfo.InvariantCulture));
            
            Console.ReadLine();
        }
    }
}