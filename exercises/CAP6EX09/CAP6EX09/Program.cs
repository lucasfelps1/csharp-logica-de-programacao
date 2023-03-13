using System.Globalization;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        int N;
        double[] elementos;
        double soma;

        N = int.Parse(Console.ReadLine());
        elementos = new double[N];

        string[] s = Console.ReadLine().Split(' ');

        soma = 0.0;
        for (int i = 0; i < N; i++)
        {
            elementos[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            soma = soma + elementos[i];
        }

        double mediaA = soma / N;

        Console.WriteLine(mediaA.ToString("F3", CultureInfo.InvariantCulture));

        for (int i = 0; i < N; i++)
        {
            if (elementos[i] < mediaA)
            {
                Console.WriteLine(elementos[i]);
            }
        }




    }
}