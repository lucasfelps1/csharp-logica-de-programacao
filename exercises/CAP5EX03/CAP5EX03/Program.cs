using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double temp, calculo;
        string opcao;

        do {

            Console.Write("Digite a temperatura em Celsius: ");
            temp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calculo = ((9.0 * temp) / 5.0) + 32.0;

            Console.WriteLine("Equivalente em Fahrenheit: " + calculo.ToString("F1", CultureInfo.InvariantCulture));

            Console.Write("Deseja repetir (s/n)? ");
            opcao = Console.ReadLine();

        } while (opcao != "n");




    }
}