namespace IfElseAskName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda nimi.");

            string name = Console.ReadLine().ToLower();

            if (name == "mati")
            {
                Console.WriteLine("Sinu nimi on Mati");
            }
            else
            {
                Console.WriteLine("Sinu nime pole Mati");
            }
        }
    }
}
