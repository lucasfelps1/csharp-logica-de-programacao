using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        String[] A;
        String[] B;
        int N;
        int[] C;


        N = int.Parse(Console.ReadLine());
        C = new int[N];

        A = Console.ReadLine().Split(' ');
        B = Console.ReadLine().Split(' ');

        int[] A1 = Array.ConvertAll(A, x => int.Parse(x));
        int[] B1 = Array.ConvertAll(B, x => int.Parse(x));

        for (int i =0; i < N; i++) {

            C[i] = A1[i] + B1[i];

        }



        for(int i = 0; i < N; i++)
        {
            Console.Write(C[i] + " ");
        }

        
    }
}