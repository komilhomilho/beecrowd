namespace Números_Ímpares;

class Program
{
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i <= input; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
