namespace IfAndElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] all_colors = [ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.White];

            Console.BackgroundColor = all_colors[new Random().Next(all_colors.Length)];

            Console.WriteLine("Värvide valik: Red, Green, Blue ja White");
            Console.WriteLine("Mis värvi on tekst");

            string värv = Console.ReadLine();


            if (Console.BackgroundColor.ToString() == värv)
            {
                Console.WriteLine("Õige!");
            }
            else
            {
                if (Enum.TryParse<ConsoleColor>(värv, out _))
                {
                    Console.WriteLine("Vale!");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
