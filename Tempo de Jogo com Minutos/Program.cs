namespace Tempo_de_Jogo_com_Minutos;

class Program
{
    static void Main(string[] args)
    {
        int[] hr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        DateTime[] data =
        {
            new DateTime(2026, 7, 1, hr[0], hr[1], 1),
            new DateTime(2026, 7, 1, hr[2], hr[3], 1)
        };
        TimeSpan calc = data[1] <= data[0] ? (data[1].AddDays(1)) - data[0] : data[1] - data[0] ;
        Console.WriteLine($"O JOGO DUROU {Math.Abs(calc.Hours == 0 && calc.Minutes == 0? 24: calc.Hours)} HORA(S) E {Math.Abs(calc.Minutes)} MINUTO(S)");
    }
}
