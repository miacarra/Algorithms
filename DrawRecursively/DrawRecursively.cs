namespace DrawRecursively
{
    internal class DrawRecursively
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            DrawRecursively(input);
        }
        static void DrawRecursively(int input)
        {


            if (input == 0)
                return;

            Console.WriteLine(new string('*', input));

            DrawRecursively(input - 1);

            Console.WriteLine(new string('#', input));


        }
        

    }
}