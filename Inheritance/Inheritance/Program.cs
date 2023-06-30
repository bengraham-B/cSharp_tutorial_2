namespace Inheritance {
    internal class Program {
        static void Main(string[] args) {
            // Chef is orginal class
            Chef chef = new Chef();
            chef.MakeChicken();

            // ItalianChef is the class which inherits from the Chef class
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();

            italianChef.MakeSpecialDish();
            chef.MakeSpecialDish();



        }
    }
}