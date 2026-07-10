namespace Múltiplos;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] mult = input.Select(x => int.Parse(x)).ToArray();
        Array.Sort(mult);
        if(mult[1]%mult[0] != 0)
        {
            Console.WriteLine("Nao sao Multiplos");
        }
        else
        {
            Console.WriteLine("Sao Multiplos");
        }
    }
}
