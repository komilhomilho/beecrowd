using System.Net.Http.Headers;

namespace Tempo_de_Jogo;

class Program
{
    static void Main(string[] args)
    {
        int[] hr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int dia = hr[0] > hr[1] ? 2 : 1;
        DateTime[] data =
        {
            new DateTime(2026, 7, 1, hr[0], 1, 1),
            new DateTime(2026, 7, dia, hr[1], 1, 1)
        };
        TimeSpan calc = data[0] - data[1];
        Console.WriteLine($"O JOGO DUROU {Math.Abs(calc.Hours == 0 ? 24 : calc.Hours)} HORA(S)");
    }
}
