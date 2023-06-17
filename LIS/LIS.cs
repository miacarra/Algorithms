
namespace LongestIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int length = array.Length;
            int[] lisArr = new int[length];
            lis(array, length);
        }
        static void lis(int[] array, int length)               //1 2 9 5 8 4 6 2
        {
            int[] lisArr = new int[length];
            int[] previousArr = new int[length];

            int bestLength = 1;
            int lastNum = 0;
            for (int i = 0; i < length; i++)
            {
                lisArr[i] = 1;
                previousArr[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    //lisArr[i] = 1;
                    if (array[i] > array[j] && lisArr[j] + 1 > lisArr[i])
                    {
                        lisArr[i] = lisArr[j] + 1;
                        previousArr[i] = j;
                        //lastNum = i;
                    }
                }
                if (lisArr[i] > bestLength)
                {
                    bestLength = lisArr[i];
                    lastNum = i;
                }
            }

            int[] result = new int[bestLength];
            for (int index = bestLength - 1; index >= 0; index--)
            {
                result[index] = array[lastNum];
                lastNum = previousArr[lastNum];
            }
            //Console.WriteLine(string.Join(' ', array));
            //Console.WriteLine(string.Join(' ', lisArr));
            //Console.WriteLine(string.Join(' ', previousArr));
            Console.WriteLine(string.Join(' ', result));
        }
    }
} 