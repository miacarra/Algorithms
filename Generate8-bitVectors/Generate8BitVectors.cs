namespace Generate8_bitVectors
{
    internal class Generate8BitVectors
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] vector = new int[length];
            MakeVector(vector,0);
        }
        static void MakeVector(int[] input, int index)
        {
            int length=input.Length;
            if (index >= length)
            {
                Console.WriteLine(string.Join(string.Empty, input));
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                input[index] = i;

                MakeVector(input, index + 1);
            }
            
        }
			

    }
}