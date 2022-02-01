using System;
public class pattern
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter rows :");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 2 * n; j++)
            {
                if (j == n + 1)
                {
                    continue;
                }
                int k = (j < n + 1) ? j : 2 * n - j + 1;
                if (k >= n + 1 - i)
                {
                    int x = (int)Math.Pow(2, (i + k - n - 1));
                    Console.Write(x);
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}