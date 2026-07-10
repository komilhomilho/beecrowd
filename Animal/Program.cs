namespace Animal;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        string tipo = Console.ReadLine();
        string dieta = Console.ReadLine();

        string animal = "";

        switch (tipo)
        {
            case "ave":
                animal = dieta == "carnivoro" ? "aguia" : "pomba";
                break;

            case "mamifero":
                animal = dieta == "onivoro" ? "homem" : "vaca";
                break;

            case "inseto":
                animal = dieta == "hematofago" ? "pulga" : "lagarta";
                break;

            case "anelideo":
                animal = dieta == "hematofago" ? "sanguessuga" : "minhoca";
                break;
        }

        Console.WriteLine(animal);
    }
}
