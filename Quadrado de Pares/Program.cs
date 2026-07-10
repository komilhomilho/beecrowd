namespace Quadrado_de_Pares;

class Program
{
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= input; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }
        }
    }
}
