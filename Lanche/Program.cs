namespace Lanche;

class Program
{
    static void Main(string[] args)
    {
        int cod, amount;
        double price = 0.0;
        string[] input = Console.ReadLine().Split(' ');
        cod = Convert.ToInt32(input[0]);
        amount = Convert.ToInt32(input[1]);
        switch (cod)
        {
            case 1:
                price = amount * 4.00;
                break;
            case 2:
                price = amount * 4.50;
                break;
            case 3:
                price = amount * 5.00;
                break;
            case 4:
                price = amount * 2.00;
                break;
            case 5:
                price = amount * 1.50;
                break;
        }
        Console.WriteLine("Total: R$ " + price.ToString("F2"));
    }
}
