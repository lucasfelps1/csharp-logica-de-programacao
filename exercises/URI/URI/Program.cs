using System.Globalization;


namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3, n4, media, notaExame, mediaExame;

            String[] vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (n1 + n2 + n3 + n4) / 4.0;

            if (media >= 7.0) {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0) {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno reprovado");
            }
            else if (media >= 5.0 && media <= 6.9) {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno em exame");

                notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + notaExame);

                mediaExame = (media + notaExame) / 2;

                if (mediaExame > 5.0) { 
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame);
                } 
                else {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaExame);
                }
                
            }
            
            

         }
       
    }
}