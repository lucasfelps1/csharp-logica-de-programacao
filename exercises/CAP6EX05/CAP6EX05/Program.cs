using System;
using System.Globalization;

int N, posicao;
double[] vetor;
double maior;

N = int.Parse(Console.ReadLine());
vetor= new double[N];

string[] s = Console.ReadLine().Split(' ');

maior = 0.0;
posicao = 0;
for (int i = 0;i < N; i++)
{
    vetor[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

    if (vetor[i] > maior && i > posicao)
    {
        maior = vetor[i];
        posicao = i;
    }

    
}

Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine(posicao);


