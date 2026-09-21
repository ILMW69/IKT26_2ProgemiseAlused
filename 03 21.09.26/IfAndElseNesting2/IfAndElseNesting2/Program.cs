namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis kell on?");

            string kell = Console.ReadLine();
            float shit = float.Parse(kell);

            if (shit < 21.01)
            {
                if (shit > 11.30 && shit < 12.30)
                {
                    Console.WriteLine("Lõuna!");
                }
                else if (shit >= 18.00)
                {
                    Console.WriteLine("Õhtu!");
                }
            }
            else if (shit < 23.59)
            {
                Console.WriteLine("Mine magama!");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
