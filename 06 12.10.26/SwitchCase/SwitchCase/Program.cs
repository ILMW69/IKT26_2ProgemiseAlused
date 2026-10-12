namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal ja vajuta enter");

            string vokaal = Console.ReadLine();

            switch (vokaal)
            {
                case "a":
                    Console.WriteLine("siestasite vokaali a");
                    break;
                case "e":
                    Console.WriteLine("siestasite vokaali e");
                    break;
                case "i":
                    Console.WriteLine("siestasite vokaali i");
                    break;
                default:
                    Console.WriteLine("sisestatud täht pole vokaal");
                    break;
            }
        }
    }
}
