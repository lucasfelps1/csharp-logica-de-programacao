using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a largura: ");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o comprimento: ");
        double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o valor por metro: ");
        double valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = largura * comprimento;

        double precoArea = area * valorMetro;

        Console.WriteLine("A area do terrono é: " + area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("E seu valor é: " + precoArea.ToString("F2", CultureInfo.InvariantCulture));



    }

}