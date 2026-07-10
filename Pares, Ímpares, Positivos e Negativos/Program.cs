namespace Pares__Ímpares__Positivos_e_Negativos;

class Program
{
    static void Main(string[] args)
    {
        double[] valores = new double[5];
        for (int i = 0; i < 5; i++)
        {
            valores[i] = Convert.ToDouble(Console.ReadLine());
        }
        Array.Sort(valores);
        Console.WriteLine($"{valores.Count(x => x % 2 == 0)} valor(es) par(es)");
        Console.WriteLine($"{valores.Count(x => x % 2 != 0)} valor(es) impar(es)");
        Console.WriteLine($"{valores.Count(x => x > 0)} valor(es) positivo(s)");
        Console.WriteLine($"{valores.Count(x => x < 0)} valor(es) negativo(s)");
    }
}
