using System;
using System.Globalization;

namespace BEE1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n*(Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + area.ToString("F4"), CultureInfo.InvariantCulture);
            
            Console.ReadLine();
        }
    }
}