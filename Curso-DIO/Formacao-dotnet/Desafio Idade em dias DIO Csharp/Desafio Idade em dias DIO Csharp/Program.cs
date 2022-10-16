using System;
using System.Globalization;

namespace IdadeDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            idade = int.Parse(Console.ReadLine());

            int ano = idade / 365;
            int restoAno = idade % 365;

            int mes = restoAno / 30;
            int restoMes = restoAno % 30;

            int dia = restoMes;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
            Console.ReadLine();
        }
    }
}