namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            /*siin on muutuja name, mis on string
             * loab andmeid konsioolist ja salvestab
             * need uutuja name sisse */
            string name = Console.ReadLine();
            
            // kui muutuja on tühi, siis väljastab konsoolile errori
            if (name != "")
            {
                Console.WriteLine("Tere, " + name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                for (byte i=1; i < 5; i++)
                {
                    Console.Beep();
                    Console.WriteLine("\"ERROR: Nimi sisestamata! " + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
