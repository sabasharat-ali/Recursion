using System;

namespace Recursion_1
{
    //A program that calculates the sum of the numbers from "n" to "m"
    class Program
    {
        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSumRecursively(n, m);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
