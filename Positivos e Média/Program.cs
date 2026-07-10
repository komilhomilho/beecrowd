using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Positivos_e_Média;

class Program
{
    static void Main(string[] args)
    {
        double[] valores = new double[6];
        for (int i = 0; i < 6; i++)
        {
            valores[i] = Convert.ToDouble(Console.ReadLine());
        }
        Array.Sort(valores);
        Console.WriteLine($"{valores.Count(x => x >= 0)} valores positivos");
        Console.WriteLine($"{(valores.Where(num => num > 0).Average()):F1}");
    }
}
