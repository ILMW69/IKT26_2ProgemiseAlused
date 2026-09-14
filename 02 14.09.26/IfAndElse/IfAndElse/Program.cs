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
                Console.WriteLine("ERROR: Nimi sisestamata!");
                for (byte i=0; i < 3; i++)
                {
                    Console.Beep();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
