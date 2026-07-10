namespace SqMoises;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o numero de vezes que quer repetir: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int i = 1, x = 2, y = 7, z = 3;
        while(i <= input)
        {
            Console.WriteLine($"{x}, {y}, {z}");
            x *=  2;
            y *=  3;
            z *=  4;
            i++;
        }

    }
}
