using System;

class ReturnStatements
{
    static void Main()
    {
        int cubedNumber = cube(5);
        Console.WriteLine(cubedNumber);
        Console.WriteLine(cube(5));

    }
    
    // This returns a int so instead of void, use int, coz void does not return anything.
    static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }
}