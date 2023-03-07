using System;
using System.Globalization;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        double idade, soma, media;
        int cont;

        idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        soma = 0.0;
        cont = 0;
        while (idade >= 0){
            soma = soma + idade;
            cont++;
            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }

        if (cont == 0) {
            Console.Write("impossivel calcular");
        }
        else
        {
            media = soma / cont;
            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
        }

        



        
       
    }
}
