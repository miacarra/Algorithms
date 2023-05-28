using System;

namespace RecursiveFactorial
{
    internal class RecursiveFactorial
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int factorialSum = GetFactorial(input);
            Console.WriteLine(factorialSum);
        }
        static int GetFactorial(int number)
        {
            if (number == 1)
                return 1;
            else return number*GetFactorial(number-1);
        }
    }
}