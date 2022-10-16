using System;
using System.Globalization;

namespace BEE1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, Horas;
            double valorPorHora, Salario;

            Numero = int.Parse(Console.ReadLine());
            Horas = int.Parse((Console.ReadLine()));
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = Horas * valorPorHora;
            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}