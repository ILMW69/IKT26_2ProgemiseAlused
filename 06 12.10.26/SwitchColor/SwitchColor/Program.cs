namespace SwitchColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta värv: Red, Green, Blue, Orange, White");

            string värv = Console.ReadLine().ToLower();

            switch (värv)
            {
                case "red":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("RED!!!!!!!!!!!");
                    break;

                case "green":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GREEN!!!!!!!!!!!");
                    break;

                case "blue":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("BLUE!!!!!!!!!!!");
                    break;

                case "orange":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("ORANGE!!!!!!!!!!!");
                    break;

                case "white":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("WHITE!!!!!!!!!!!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("sisestasite teise värvi!");
                    break;

            }
        }
    }
}
