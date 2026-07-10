using System.Buffers;
using System.Data;

namespace Tipos_de_Triângulos;

class Program
{
    static void Main(string[] args)
    {
        double[] vertices = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).OrderByDescending(x => x).ToArray();
        double[] potencia = vertices.Select(x => Math.Pow(x, 2)).OrderByDescending(x => x).ToArray();
        if(vertices[0] >= (vertices[1] + vertices[2]))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (potencia[0] == (potencia[1] + potencia[2]))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (potencia[0] >= (potencia[1] + potencia[2]))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (potencia[0] <= (potencia[1] + potencia[2]))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if(vertices.GroupBy(x => x).Any(g => g.Count() == 2))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            else if(vertices.GroupBy(x => x).Any(g => g.Count() == 3))
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
        }
    }
}
