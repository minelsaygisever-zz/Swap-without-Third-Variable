// This program replaces the values of two numeric variables without using a third variable.
// Minel SAYGISEVER

using System;

namespace SwapWithoutThirdVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            b = a + b; // b = 3
            a = b - a; // a = 2
            b = b - a; // b = 1

            Console.WriteLine("The value of the 1st variable: {0}", a);
            Console.WriteLine("The value of the 2nd variable: {0}", b);
        }
    }
}
