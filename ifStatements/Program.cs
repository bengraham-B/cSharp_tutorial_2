using System;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall dude, nice.");
            }
            else if (isMale || isTall)
            {
                Console.WriteLine("Your are a dude or tall");
            }
            else if(!isTall)
            {
                Console.WriteLine("You are a dude, nice.");
            }
            else
            {
                Console.WriteLine("You are not a dude or not tall or niether");
            }
            Console.WriteLine("Hello World!");
        }
    }
}