namespace StaticMethodsAndClasses {
    internal class Program {
        static void Main(string[] args) {

            //accessing method directly without creating an instance of useful tools class
            UsefulTools.SayHi("Ben");
            Console.ReadLine();
        }
    }
}