using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SumArrayRecursively
{
    internal class SumArrayRecursively
    {
        static void Main(string[] args)
        {
            int[] input=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum=SumRecursively(input,0);
            Console.WriteLine(sum);
        }
        static int SumRecursively(int[] input, int index)
        {

            if (index == input.Length - 1)
                return input[index];

                return input[index]+SumRecursively(input,index+1);
        }
    }
}