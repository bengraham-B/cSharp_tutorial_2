namespace _2dArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating 2D array
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6 }
            };

            // How to delcare an array if you do not know what will go in.
            int[,] myArray = new int[2, 3]; // The 2 is for rows and the 3 for colums

            Console.WriteLine(numberGrid[1, 1]);
        }
    }
}