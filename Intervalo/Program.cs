namespace Intervalo;

using System;

class Program
{
    static void Main(string[] args)
    {
        double input;
        input = Convert.ToDouble(Console.ReadLine());
        if (input >= 0)
        {
            if (input <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (input <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (input <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (input <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}
