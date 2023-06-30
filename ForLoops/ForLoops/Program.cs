namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] luckNumbers = { 1, 34, 22, 564, 2028 };

            for (int i = 0; i < luckNumbers.Length; i++)
            {
                  Console.WriteLine(luckNumbers[i]);

            }
        }
    }
}