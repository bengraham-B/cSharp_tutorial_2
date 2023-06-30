namespace ExponentMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine( GetPow(5, 12));
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}