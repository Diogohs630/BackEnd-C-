using System;
using System.Globalization;

namespace BEE1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int Hora = N / 3600;
            int Resto = N % 3600;
            int Minutos = Resto / 60;
            int Segundos = Resto % 60;

            Console.WriteLine(Hora + ":" + Minutos + ":" + Segundos);
            Console.ReadLine();
        }
    }
}