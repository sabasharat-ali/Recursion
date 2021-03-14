using System;

namespace Recursion_2
{
    //Program to print factorials recursively
    class Factorial
    {

        public int factR(int n)
        {
            int result;

            if (n == 1) return 1;
            result = factR(n - 1) * n;
            return result;
        }
        class Program
        {
            static void Main(string[] args)
            {
               
                Factorial f = new Factorial();
                Console.WriteLine("Factorial of 3 is " + f.factR(3));
                Console.WriteLine("Factorial of 4 is " + f.factR(4));
                Console.WriteLine("Factorial of 5 is " + f.factR(5));
                Console.WriteLine();
            }
        }
    }
}

