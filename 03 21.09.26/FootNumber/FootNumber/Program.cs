namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seikleja! Kas otsite Jalanõusi?");

            string vastus = Console.ReadLine();

            if (vastus != "jah")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Mis on su jalanumber seikleja?");

            byte jala_number = byte.Parse(Console.ReadLine());

            bool teine_jalanumber = false;

            if (jala_number >= 30 && jala_number <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (jala_number >= 34 && jala_number <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (jala_number >= 39 && jala_number <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (jala_number >= 45 && jala_number <= 48)
            {
                Console.Beep();
            }
            else
            {
                teine_jalanumber = true;
                Console.WriteLine("Vabandust seikleja aga me ei pakku selles suuruses jalanõusi.");
            }

            if (!teine_jalanumber)
            {
                Console.WriteLine("Kohe toon jalatsid su suuruses.");
            }
        }
    }
}
