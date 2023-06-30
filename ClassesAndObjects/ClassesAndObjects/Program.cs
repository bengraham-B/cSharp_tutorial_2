namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args) {
            Book book1 = new Book("Harry Potter", "J.K Rowling", 400);
           
            Book book2 = new Book("Lord of the rings", "Tolkien", 700);

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.pages);


            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}