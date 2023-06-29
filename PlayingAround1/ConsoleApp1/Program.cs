namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Do you want to square root a number or cude it?");
            Console.WriteLine("1: Square the Number");
            Console.WriteLine("2: Cube the Number");

            string userInput = Console.ReadLine();  

            if (userInput == "1")
            {
                Console.WriteLine("Enter Number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                int result = square(userNumber);

                Console.WriteLine("Answer: " + result);
            }

            else if(userInput == "2")
            {
                Console.WriteLine("Enter a Number");

                int userNumber = Convert.ToInt32(Console.ReadLine());
                int result = cube(userNumber);

                Console.WriteLine("Answer: " + result);
            }

            else
            {
                Console.WriteLine("Please enter a valid option");
            }
        }

        static int square(int number)
        {
            return number * number;
        }

        static int cube(int number)
        {
            return number * number * number;
        }


    }
}