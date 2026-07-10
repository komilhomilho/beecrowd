namespace Maior_e_Posição;

class Program
{
    static void Main(string[] args)
    {
        int value, position = 0, testedValue = 0;
        for (int i = 1; i <= 100; i++)
        {
            value = int.Parse(Console.ReadLine());
            if(value > testedValue)
            {
                testedValue = value;
                position = i;
            }
        }
        Console.WriteLine($"{testedValue}\n{position}");
    }
}
