namespace StaticAttributesInClasses {
    internal class Program {
        static void Main(string[] args) {

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zepplin", 150);
            Console.WriteLine(Song.songCount);
            Song sammy = new Song("Sammy", "Jim Bluen", 135);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(sammy.getSongCount()); // Accessing songCount (static attribute) from indivdual object.



            Console.ReadLine();
        }
    }
}