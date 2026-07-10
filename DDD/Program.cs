namespace DDD;

class Program
{
    static void Main(string[] args)
    {
        string[,] ddds =
        {
            {"61", "Brasilia"},
            {"71", "Salvador"},
            {"11", "Sao Paulo"},
            {"21", "Rio de Janeiro"},
            {"32", "Juiz de Fora"},
            {"19", "Campinas"},
            {"27", "Vitoria"},
            {"31", "Belo Horizonte"},
        };
        int ddd = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < ddds.GetLength(0); i++)
        {
            if (ddd == Convert.ToInt32(ddds[i, 0]))
            {
                Console.WriteLine(ddds[i, 1]);
                Environment.Exit(0);
            }
        }
        Console.WriteLine("DDD nao cadastrado");
    }
}
