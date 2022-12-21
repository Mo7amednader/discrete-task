using System;
public class Exercise28
{
    public static void Main()
    {
        int n, i, sum;
        int n1, n2;

        Console.Write("\n\n");
        Console.Write("Find perfect numbers within a given number of range:\n");
        Console.Write("------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the starting range or number : ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers within the given range : ");
        for (n = n1; n <= n2; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }
}
