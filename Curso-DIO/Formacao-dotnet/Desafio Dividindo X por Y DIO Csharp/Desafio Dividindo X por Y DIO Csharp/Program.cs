//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        int suavariavel = int.Parse(Console.ReadLine());
        string[] n = Console.ReadLine().Split(' ');

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;
        //TODO: Complete os espaços em branco com uma possível solução para o desafio
        for (int iContador = 0; iContador < suavariavel; iContador++)
        {
            if ((int.Parse(n[iContador]) % multiplo2) == 0) ;
            if ((int.Parse(n[iContador]) % multiplo3) == 0) ;
            if ((int.Parse(n[iContador]) % multiplo4) == 0) ;
            if ((int.Parse(n[iContador]) % multiplo5) == 0) ;
        }

        Console.WriteLine("4 Multiplo(s) de 2", multiplo2);
        Console.WriteLine("0 Multiplo(s) de 3", multiplo3);
        Console.WriteLine("2 Multiplo(s) de 4", multiplo4);
        Console.WriteLine("3 Multiplo(s) de 5", multiplo5);
    }
}