using System;
using System.Globalization;

namespace BEE1010
{
    class Program
    {
        static void Main()
        {
            /*
            int codPeca1, codPeca2, nPecas1, nPecas2;
            double valor1, valor2, valorTotal;

            string[] pecas1 = Console.ReadLine().Split(" ");
            codPeca1 = int.Parse(pecas1[0]);
            nPecas1 = int.Parse(pecas1[1]);
            valor1 = double.Parse(pecas1[2], CultureInfo.InvariantCulture);
            string[] pecas2 = Console.ReadLine().Split(" ");
            codPeca2 = int.Parse(pecas2[0]);
            nPecas2 = int.Parse(pecas2[1]);
            valor2 = double.Parse(pecas2[2], CultureInfo.InvariantCulture);

            valorTotal = (nPecas1 * valor1) + (nPecas2 * valor2);
            */

            String line1 = Console.ReadLine();
            String line2 = Console.ReadLine();

            String[] values1 = line1.Split(' ');
            int codPeca1 = Int32.Parse(values1[0]);
            int numPecas1 = Int32.Parse(values1[1]);
            double valorPeca1 = Convert.ToDouble(values1[2], CultureInfo.InvariantCulture);

            String[] values2 = line2.Split(' ');
            int codPeca2 = Int32.Parse(values2[0]);
            int numPecas2 = Int32.Parse(values2[1]);
            double valorPeca2 = Convert.ToDouble(values2[2], CultureInfo.InvariantCulture);

            double valorTotal = (numPecas1 * valorPeca1) + (numPecas2 * valorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();

        }
    }
}