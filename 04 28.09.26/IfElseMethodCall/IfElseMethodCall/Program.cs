namespace IfElseMethodCall
{
    internal class Program
    {
        // see on meetod main
        static void Main(string[] args)
        {
            Console.WriteLine("Kas soovid meetodit Hello kasutada: y/n");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Hello();
            }
            else if (key.Key == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine("awww :(");
            }

        }

        // tehke uus meetod nimega Hello
        static void Hello()
        {
            Console.WriteLine("Hello Wolvie Kawaii");
        }
    }
}
