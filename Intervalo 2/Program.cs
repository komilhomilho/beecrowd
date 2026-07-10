using System.Security.Cryptography.X509Certificates;

namespace Intervalo_2;

class Program
{
    static void Main(string[] args)
    {
        int[] resultados = {0, 0};
        int input = Convert.ToInt16(Console.ReadLine());
        int[] valoresTeste = new int[input];
        for(int i = 0; i < valoresTeste.Length; i++)
        {
            valoresTeste[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach(int valor in valoresTeste)
        {
            if(valor > 9 && valor < 21)
            {
                resultados[0] += 1;
            }
            else
            {
                resultados[1] += 1;
            }
        };
        Console.WriteLine($"{resultados[0]} in\n{resultados[1]} out");
    }
}
