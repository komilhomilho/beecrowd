namespace Médias_Ponderadas;

class Program
{
    static void Main(string[] args)
    {
        int numberCasesTest = int.Parse(Console.ReadLine());
        int[] weights = { 2, 3, 5 };
        float[] result = new float[numberCasesTest];
        for (int calculations = 0; calculations < numberCasesTest; calculations++)
        {
            float[] numbers = Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray();
            if (numbers.Length > weights.Length)
            {
                Console.WriteLine("Erro Não a pesos o Suficiente para essa quantida de notas");
                break;
            }
            for (int sum = 0; sum < 3; sum++)
            {
                result[calculations] += numbers[sum] * weights[sum];
            }
            result[calculations] /= weights.Sum();
        }
        for(int toPresent = 0; toPresent < numberCasesTest; toPresent++)
        {
            Console.WriteLine($"{result[toPresent]:0.0}");
        }
    }

}

