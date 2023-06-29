using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0))
            Console.WriteLine("Hello World!");
        }
    }

    static string GetDay(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;

            case 1:
                dayName = "Monday"; 
                break;

            case 2:
                dayName = "Tuesday";
                break;

            case 3:
                dayName = "Wednesday";
                break;

            default:
                dayName = "Not Valid";
        }

        return dayName;
    }
}
