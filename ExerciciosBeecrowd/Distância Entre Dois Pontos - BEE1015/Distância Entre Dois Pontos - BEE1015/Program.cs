using System;
using System.Globalization;

namespace BEE1015
{
    class Program
    {
        static void Main(string[] args)
        {
            String line1 = Console.ReadLine();
            String line2 = Console.ReadLine();

            String[] values1 = line1.Split(' ');
            double x1 = double.Parse(values1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(values1[1], CultureInfo.InvariantCulture);
            String[] values2 = line2.Split(' ');
            double x2 = double.Parse(values2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(values2[1], CultureInfo.InvariantCulture);

            double potenciaX = (double)(Math.Pow((x2 - x1), 2.00));
            double potenciaY = (double)(Math.Pow((y2 - y1), 2.00));
            double distancia = (double) Math.Sqrt(potenciaX + potenciaY);
            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}