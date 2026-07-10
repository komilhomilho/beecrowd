namespace Sort_Simples;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] order = new int[3];
        int i;
        for (i = 0; i < 3; i++)
        {
            order[i] = int.Parse(input[i]);
        }
        Array.Sort(order);
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine(order[i]);
        }
        Console.WriteLine();
        for(i = 0; i < 3; i++)
        {
            Console.WriteLine(input[i]);
        }
    }
}
