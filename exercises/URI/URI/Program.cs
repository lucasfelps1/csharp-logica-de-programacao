internal class Program
{
    private static void Main(string[] args)
    {

        string[] vetor = Console.ReadLine().Split(' '); 

        double A = double.Parse(vetor[0]);
        double B = double.Parse(vetor[1]);
        double C = double.Parse(vetor[2]);

        Console.WriteLine(A + B + C);

    }
}