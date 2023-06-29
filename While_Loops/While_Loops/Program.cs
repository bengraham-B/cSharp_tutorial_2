using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loops!");

            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++; // Incrementing 
            }
            
            int indexDo = 1;

           do
            {
                Console.WriteLine(index);
                indexDo++; // Incrementing 
            } while (indexDo <= 5) ;
        }
    }
}