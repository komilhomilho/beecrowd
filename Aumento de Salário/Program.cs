namespace Aumento_de_Salário;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        double[,] percentual =
        {
            {0, 400.00, 0.15},
            {400.01, 800.00, 0.12},
            {800.01, 1200.00, 0.10},
            {1200.01, 2000.00, 0.07},
            {2000.01, double.MaxValue, 0.04}
        };
        
        double salario = Convert.ToDouble(Console.ReadLine());
        double perc = 0;

        for (int i = 0; i < percentual.GetLength(0); i++)
        {
            if (salario >= percentual[i, 0] && salario <= percentual[i, 1])
            {
                perc = percentual[i, 2];
                break;
            }
        }
        double reajuste = salario * perc;
        double novoSalario = salario + reajuste;

        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
        Console.WriteLine($"Em percentual: {perc * 100:F0} %");
    }
}
