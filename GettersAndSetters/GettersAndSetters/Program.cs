namespace GettersAndSetters {
    internal class Program {
        static void Main(string[] args) {

            Movie movie1 = new Movie("The avangers", "Joss Moss", "PG13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "G");

            movie1.Rating = "Goose";
            Console.WriteLine(movie1.Rating);

            movie1.Rating = "R";
            Console.WriteLine(movie1.Rating);

            Console.ReadLine();
        }
    }
}