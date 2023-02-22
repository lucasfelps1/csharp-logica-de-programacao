using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com o seu nome completo:");
        string nome1 = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa:");
        int numQuarto = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto:");
        double valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre seu ultimo nome, idade e altura:");

        String[] dados = Console.ReadLine().Split(" ");

        string nome2 = dados[0];
        int idade = int.Parse(dados[1]);
        double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome1);
        Console.WriteLine(numQuarto);
        Console.WriteLine(valorProd.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(nome2);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

    }
}