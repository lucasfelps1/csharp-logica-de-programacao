using System.Globalization;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = nota1 + nota2;

        Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));

        if (media < 60)
        {
            Console.WriteLine("REPROVADO");
        }

        

    }
}