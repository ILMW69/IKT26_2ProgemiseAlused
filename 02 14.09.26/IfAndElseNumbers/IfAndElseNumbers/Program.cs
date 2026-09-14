using System.Drawing;

namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");


            /* peate kasutam aif and else,
             * et kontrollida kas kasutaja on suurem
             * või väiksem kui 18 */

            string age_str = Console.ReadLine();
            byte age = byte.Parse(age_str);

            if (age >= 18)
            {
                Console.WriteLine("unc");
            }
            else 
            {
                Console.WriteLine("beebi");
            }
        }
    }
}
