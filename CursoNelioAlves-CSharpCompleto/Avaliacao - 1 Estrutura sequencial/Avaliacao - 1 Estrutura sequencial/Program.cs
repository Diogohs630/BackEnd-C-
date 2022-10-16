using System;
using System.Globalization;

namespace Avaliacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, n1, n2;
            double v1, v2;
            string[] vet1 = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");
            cod1 = int.Parse(vet1[0]);
            n1 = int.Parse(vet1[1]);
            v1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            cod2 = int.Parse(vet2[0]);
            n2 = int.Parse(vet2[1]);
            v2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double vPagar = ((n1 * v1) + (n2 * v2));
            Console.WriteLine("VALOR A PAGAR: R$ " + vPagar.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
