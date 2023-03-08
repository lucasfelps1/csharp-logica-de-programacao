using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {

        int N;
        double[] vet;

        N = int.Parse(Console.ReadLine());
        vet = new double[N];

        for(int i = 0; i < N; i++)
        {
            vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        for(int i = 0; i < N; i++)
        {
            Console.WriteLine(vet[i].ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}