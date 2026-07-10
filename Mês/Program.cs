using System.Globalization;

namespace Mês;

class Program
{
    static void Main(string[] args)
    {
        byte i = Convert.ToByte(Console.ReadLine());
        DateTime mes = new DateTime(2027, i, 1);
        Console.WriteLine(mes.ToString("MMMM", new CultureInfo("en-US")));
    }
}
