using System.Data;

namespace Tempo_de_um_Evento;

class Program
{
    static void Main(string[] args)
    {
        int[] dataColletor = new int[4];
        dataColletor[0] = Convert.ToInt16(Console.ReadLine().Split(' ')[1]);
        string[] data = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        for(int i = 1; i < 4; i++)
        {
            dataColletor[i] = Convert.ToInt16(data[i - 1]);
        }
        DateTime inico = new DateTime(2022, 4, dataColletor[0], dataColletor[1], dataColletor[2], dataColletor[3]);
        dataColletor[0] = Convert.ToInt16(Console.ReadLine().Split(' ')[1]);
        data = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 1; i < 4; i++)
        {
            dataColletor[i] = Convert.ToInt16(data[i - 1]);
        }
        DateTime fim = new DateTime(2022, 4, dataColletor[0], dataColletor[1], dataColletor[2], dataColletor[3]);
        TimeSpan Tempo = fim - inico;
        Console.WriteLine($"{Tempo.Days} dia(s)");
        Console.WriteLine($"{Tempo.Hours} hora(s)");
        Console.WriteLine($"{Tempo.Minutes} minuto(s)");
        Console.WriteLine($"{Tempo.Seconds} segundo(s)");
    }
}
