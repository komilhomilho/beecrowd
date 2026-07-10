namespace Números_Positivos;

class Program
{
    static void Main(string[] args)
    {
        double[] valores = new double[6];
        for (int i = 0; i < 5; i++)
        {
            valores[i] = Convert.ToDouble(Console.ReadLine());
        }
        Array.Sort(valores);
        Console.WriteLine($"{valores.Count(x => x >= 0)} valores positivos");
        
    }
}
