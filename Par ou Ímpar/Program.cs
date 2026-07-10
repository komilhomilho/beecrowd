using System.ComponentModel;

namespace Par_ou_Ímpar;

class Program
{
    static void Main(string[] args)
    {
        int rigthAway = int.Parse(Console.ReadLine());
        int[] numbers = new int[rigthAway];
        string[] response = new string[2];
        int i;
        for (i = 0; i < rigthAway; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for(i = 0; i < rigthAway; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                response[0] = "EVEN";
            }
            else
            {
                response[0] = "ODD";
            }

            if (numbers[i] == 0)
            {
                response[0] = "NULL";
                response[1] = "";
            }
            else if (numbers[i] > 0)
            {
                response[1] = " POSITIVE";
            }
            else
            {
                response[1] = " NEGATIVE";
            }
            Console.WriteLine($"{response[0]}{response[1]}");
        }
    }
}
