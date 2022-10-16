using System;
using System.Globalization;

namespace BEE1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            double soma = 0.0;
            int cont = 0;
            while ( idade > 0)
            {
                soma += idade;
                idade = int.Parse(Console.ReadLine());
                cont++;
            }

            double mediaIdade = soma / cont;
            Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}