namespace Triângulo;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        double[] vertices = input.Select(x => double.Parse(x)).ToArray();
        double[] result = new double[3];
        double calc = 0;
        result[0] = vertices[0] + vertices[1];
        result[1] = vertices[1] + vertices[2];
        result[2] = vertices[2] + vertices[0];
        if (result.Any(resultado => vertices.Contains(resultado)))
        {
            calc = ((vertices[0] + vertices[1]) * vertices[2]) / 2;
            Console.WriteLine("Area = " + calc.ToString("F1"));
        }
        else
        {
            calc = vertices[0] + vertices[1] + vertices[2];
            Console.WriteLine("Perimetro = " + (Math.Truncate(calc*10)/10).ToString("F1"));
        }
    }
}
