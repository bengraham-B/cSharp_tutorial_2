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
            
            // GetMax Method
            Console.WriteLine(GetMax(2, 232, 320));
        }
        
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}