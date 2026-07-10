namespace Imposto_de_Renda;

class Program
{
    static void Main(string[] args)
    {
        double[,] impostos =
        {
            {0, 2000.00, 0},
            {2000.01, 3000.00, 0.08},
            {3000.01, 4500.00, 0.18},
            {4500.01, double.MaxValue, 0.28}
        };
        double taxa = 0;
        double salario = Convert.ToDouble(Console.ReadLine());
        if (salario <= 2000.00)
        {
            Console.WriteLine("Isento");
            Environment.Exit(0);
        }
        else
        {
            salario -= 2000;
            if (salario > 1000)
            {
                salario -= 1000;
                taxa = 1000 * impostos[1, 2];
                if (salario > 1500)
                {
                    salario -= 1500;
                    taxa += 1500 * impostos[2, 2];
                    if (salario != 0)
                    {
                        taxa += salario * impostos[3, 2];

                    }
                }
                else
                {
                    taxa += salario * impostos[2, 2];
                }
            }
            else
            {
                taxa = salario * impostos[1, 2];
            }
        }
        Console.WriteLine($"R$ {taxa:F2}");
    }
}
