using System;
using System.Globalization;

namespace BEE1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codItem = int.Parse(vet[0]);
            int qtdItem = int.Parse(vet[1]);
            double valorTotal;

            switch (codItem){
                case 1:
                    valorTotal = (double) qtdItem * 4.00;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    valorTotal = (double) qtdItem * 4.50;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    valorTotal = (double) qtdItem * 5.00;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    valorTotal = (double) qtdItem * 2.00;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    valorTotal = (double) qtdItem * 1.50;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            
            Console.ReadLine();
        }
    }
}