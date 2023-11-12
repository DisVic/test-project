namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("This is a new feature.");
            Console.WriteLine("An addition to the first feature.");

            Console.WriteLine("Incoming the second feature loop!");

            for (int i = 0; i < 3; i++)
                Console.WriteLine("This is the second feature.");
        }
    }
}