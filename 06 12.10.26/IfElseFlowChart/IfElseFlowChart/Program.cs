namespace IfElseFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja Else");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("you entered 1");
            }
            else if (input == "2")
            {
                Console.WriteLine("you entered 2");
            }
            else
            {
                Console.WriteLine("you entered smth else");
            }
        }
    }
}
