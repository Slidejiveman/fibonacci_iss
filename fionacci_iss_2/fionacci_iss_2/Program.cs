﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fionacci_iss_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "0";
            while (Int32.Parse(input) != -1)
            {
                Console.WriteLine("What number in the fibonacci sequence would you like to kow the value of?");
                input = Console.ReadLine();
                Console.WriteLine("The value of the requested number in the fibonacci sequence is: " + fib(Int32.Parse(input)));
                Console.WriteLine("Compared to the recursive fibonacci function's value: " + otherfib(Int32.Parse(input)) + "\n");
            }
        }

        public static int fib ( int n )
        {
            int a = 1, b = 2;
            a = (a + 13) / ((--b) + 13);        // use the side effect of --b so b is 1 like before
            for (int i = 1; i < n - 1; i++)     // run the loop the same number of times
            {
                int temp = a;                   // perform the same swap as before
                a = a + b;
                b = temp;
            }
            return a;                           // return a becasue its the accumulator
        }

        public static int otherfib( int n)
        {
            if (n <= 2) return 1;
            return otherfib(n - 1) + otherfib(n - 2);
        }
    }
}
