using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        int N, count;
        int[] nums;
        double soma, mediaA;

        N = int.Parse(Console.ReadLine());
        nums = new int[N];

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(s[i]);
        }

        soma = 0.0;
        count = 0;
        for (int i = 0; i < N; i++)
        {
            if (nums[i] % 2 == 0)
            {
                soma = soma + (double) nums[i];
                count = count + 1;
            }

        }

        mediaA = soma / (double) count;

        Console.WriteLine(mediaA.ToString("F1", CultureInfo.InvariantCulture));


    }
}