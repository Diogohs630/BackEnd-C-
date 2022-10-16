using System;

namespace BEE1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            int tempoJogo;

            if (horaInicio < horaFinal)
            {
                tempoJogo = horaFinal - horaInicio;
            }
            else
            {
                tempoJogo = 24 - horaInicio + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + tempoJogo + " HORA(S)");
            Console.ReadLine();
        }
    }
}