namespace Coordenadas_de_um_Ponto;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        double[] cordenadas = { double.Parse(input[0]), double.Parse(input[1]) };
        if (cordenadas[0] == 0 && cordenadas[1] == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (cordenadas[0] == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (cordenadas[1] == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (cordenadas[1] > 0)
        {
            if (cordenadas[0] > 0)
            {
                Console.WriteLine("Q1");
            }
            else
            {
                Console.WriteLine("Q2");
            }
        }
        else
        {
            if (cordenadas[0] > 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Q3");
            }
        }
    }
}
