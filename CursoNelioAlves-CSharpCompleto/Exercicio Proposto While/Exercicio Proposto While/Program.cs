using System;
using System.Globalization;

namespace ExercicioWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            double mediaIdade = 0.0;
            double soma = 0.0, i = 0;

            if (idade >= 0)
            {
                while (idade >= 0)
                {
                    soma += idade;
                    idade = int.Parse(Console.ReadLine());
                    i++;
                    mediaIdade = soma / i;
                }
                Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("impossível calcular");
            }
            Console.ReadLine();
        }
    }
}