internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums;
        int pares, posicao;

        int N = int.Parse(Console.ReadLine());
        nums = new int[N];

        string[] s = Console.ReadLine().Split(' ');

        posicao = 0;
        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(s[i]);

            if (nums[i] % 2 == 0)
            {   
                Console.Write(nums[i] + " ");
                posicao++;
            }

        }

        Console.WriteLine();
        Console.WriteLine(posicao);
    }
}