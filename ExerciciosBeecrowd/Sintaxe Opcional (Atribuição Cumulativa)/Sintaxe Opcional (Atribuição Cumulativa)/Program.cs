using System;
using System.Globalization;

namespace AtribuicaoCumilativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuto;
            double conta = 50.0;

            minuto = int.Parse(Console.ReadLine());

            if (minuto > 100)
            {
                //conta = conta + (minuto - 100) * 2.0; Forma tradicional
                conta += (minuto - 100) * 2.0; // Atribuição cumulativa
            }
            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
