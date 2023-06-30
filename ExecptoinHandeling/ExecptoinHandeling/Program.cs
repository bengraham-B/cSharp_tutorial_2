namespace ExecptoinHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("ENter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            // Catches only the Divide by zero exception
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            // Catches only the format exception
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            // Code here will always be executed
            finally
            {
                Console.WriteLine("Finally Bloc");
            }



        }
    }
}