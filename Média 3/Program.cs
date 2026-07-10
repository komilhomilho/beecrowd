namespace Média_3;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] pesos = { 2, 3, 4, 1 };
        double nota = 0, mediaExame, media;
        for (int i = 0; i < 4; i++)
        {
            nota += Convert.ToDouble(input[i]) * (double) pesos[i];
        }
        media = nota / 10;;
        Console.WriteLine("Media: "+ (Math.Truncate((media*10))/10).ToString("F1"));
        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media <= 6.9)
        {
            Console.WriteLine("Aluno em exame.");
            double exame = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + exame.ToString("F1"));
            mediaExame = ((media + exame) / 2);
            if (mediaExame >4.9)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: "+ (Math.Truncate((mediaExame*10))/10).ToString("F1"));
            }
        }
    }
}
