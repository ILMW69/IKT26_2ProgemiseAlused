namespace IfAndElseHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kui kõrge sa oled?");

            byte height = byte.Parse(Console.ReadLine());

            Console.WriteLine("Sinu pikkus on " + height);
            }
        }
    }
}
