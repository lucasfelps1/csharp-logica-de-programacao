using System.Globalization;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomes;
        int[] idades;
        double[] alturas;

        int N = int.Parse(Console.ReadLine());
        nomes = new string[N];
        idades = new int[N];
        alturas = new double[N];

        
        // Leitura dos dados
        for (int i = 0; i < N; i++)
        {
            string[] linhas = Console.ReadLine().Split(' ');

            nomes[i] = linhas[0];
            idades[i] = int.Parse(linhas[1]);
            alturas[i] = double.Parse(linhas[2], CultureInfo.InvariantCulture);
        }

        // Calculo da altura media das pessoas

        double soma = 0;

        for (int i=0; i<N; i++)
        {
            soma = +alturas[i];
        }

        double media = soma / N;
        Console.WriteLine("altura media: " + media.ToString("f2", CultureInfo.InvariantCulture));

        // Porcentagem de pessoas abaixo de 16 anos

        int cont = 0;
        for(int i=0; i<N; i++) 
        { 
            if (idades[i] < 16) 
            {
                cont++;
            }
        }

        double porcentagem = (double) cont / N * 100.0;
        Console.WriteLine("pessoas com menos de 16 anos: " + porcentagem.ToString("f2", CultureInfo.InvariantCulture));
       
    }
}