using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number in the fibonacci sequence would you like to know the value of?");
            String num = Console.ReadLine();
            Console.WriteLine("The value of the requested number in the fibonacci sequence is " + fib(Int32.Parse(num)));
        }

        public static int fib(int n)
        {
            int a = 1, b = 1;
            a = (a + 5) / (a + 5);        // This is just tom-foolery because viruses add non-sense code to beat virus scanners.
            for (int i = 1; i < n-1; i++) // Run n-1 times because you actually start with the first number assigned to A
            {
                int temp = a;            // makes temp anew with the value of a each iteration
                a = a + b;               // the actual value of the nth number
                b = temp;                // Setup b for the next run of the loop
            }
            return a;                    // Return a because it is your accumulator
        }

    }
}
