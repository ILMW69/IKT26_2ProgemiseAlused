namespace IfElseOddAndEvenNumbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if ((num % 2) == 0.0)
            {
                //Console.WriteLine("number on paaris");
                evenOrNot(true);
            }
            else
            {
                //Console.WriteLine("number on paaritu");
                evenOrNot(false);
            }
        }

        static void evenOrNot(bool even)
        {
            if (even)
            {
                Console.WriteLine("number on paaris");
            }
            else
            {
                Console.WriteLine("number on paaritu");
            }
        }
    }
}
