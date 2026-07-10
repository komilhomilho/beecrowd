namespace NotasClasse;

class Program
{
    static void Main(string[] args)
    {
        int[,] classe = new int[6, 2];
        int[] notasM = new int[7];
        int[] resultadoSala = new int[3];
        for (int aluno = 0; aluno < 6; aluno++)
        {
            for (int nota = 0; nota < 2; nota++)
            {
                Console.Write($"Insira a {nota + 1}º nota do {aluno + 1}º aluno: ");
                classe[aluno, nota] = Convert.ToInt32(Console.ReadLine());
                notasM[aluno] += classe[aluno, nota];
            }
            notasM[aluno] /= 2;
            notasM[6] += notasM[aluno];
            if (notasM[aluno] <= 3)
            {
                Console.WriteLine($"Aluno {aluno}º: Está Reprovado");
                resultadoSala[0]++;
            }
            else if (notasM[aluno] <= 7)
            {
                Console.WriteLine($"Aluno {aluno}º: Está Exame");
                resultadoSala[1]++;
            }
            else
            {
                Console.WriteLine($"Aluno {aluno}º: Está Aprovado");
                resultadoSala[2]++;
            }
        }
        notasM[6] /= 6;
        Console.WriteLine($"Parabens {resultadoSala[0]} Dos Seus Alunos Foram Aprovados");
        Console.WriteLine($"{resultadoSala[1]} Dos Seus Alunos Estão de Exame");
        Console.WriteLine($"{resultadoSala[0]} Dos Seus Alunos Precisarão de Reforço(Reprovados)");
        Console.WriteLine($"A media Da sala é: {notasM[6]:F2}");

    }
}
