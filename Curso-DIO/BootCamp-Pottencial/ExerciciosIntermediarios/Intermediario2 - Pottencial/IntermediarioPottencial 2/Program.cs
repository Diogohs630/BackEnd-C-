using System;
using System.Globalization;

namespace IntermediarioPottencial2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double reajuste, reajusteGanho, novoSalario;

            if (salario >= 0.00 && salario <= 400.00)
            {
                reajuste = 15.0;
                novoSalario = ((salario / 100) * reajuste) + salario;
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajuste.ToString("F0", CultureInfo.InvariantCulture) + " %");

            }
            else if (salario > 400.00 && salario <= 800)
            {
                reajuste = 12.0;
                novoSalario = ((salario / 100) * reajuste) + salario;
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajuste.ToString("F0", CultureInfo.InvariantCulture) + " %");

            }
            else if (salario > 800 && salario <= 1200.00)
            {
                reajuste = 10.0;
                novoSalario = ((salario / 100) * reajuste) + salario;
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajuste.ToString("F0", CultureInfo.InvariantCulture) + " %");

            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = 7.0;
                novoSalario = ((salario / 100) * reajuste) + salario;
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajuste.ToString("F0", CultureInfo.InvariantCulture) + " %");

            }
            else if (salario > 2000.00)
            {
                reajuste = 4.0;
                novoSalario = ((salario / 100) * reajuste) + salario;
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + reajuste.ToString("F0", CultureInfo.InvariantCulture) + " %");

            }

            Console.ReadLine();
        }
    }
}