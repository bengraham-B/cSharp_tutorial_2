using System;

class Program
{
    static void Main()
    {
      SayHi("Ben", 23);
       

    }
    // Void returns nothing
    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hello " + name);
        Console.WriteLine("You are " + age);
        Console.WriteLine("From Method");
    }
}