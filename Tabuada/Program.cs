namespace Tabuada;

class Program
{
    static void Main(string[] args)
    {
        int multiplier = int.Parse(Console.ReadLine());
        for(int multiplying = 1; multiplying <= 10; multiplying++)
        {
            Console.WriteLine($"{multiplying} x {multiplier} = {multiplying * multiplier}");
        }
    }
}
