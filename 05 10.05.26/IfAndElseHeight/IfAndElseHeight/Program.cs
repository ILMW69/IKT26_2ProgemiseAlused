namespace IfAndElseHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kui kõrge sa oled?");

            byte height = byte.Parse(Console.ReadLine());

            if (height >= 40 && height <= 80)
            {
                Console.WriteLine("Sinu pikkus on " + height);
            }
            else if (height >= 81 && height <= 130)
            {
                Console.WriteLine($"Sinu pikkus on {height}cm");
            }
            else if (height >= 131 && height <= 170)
            {
                Console.WriteLine($"Sinu pikkus on {height}cm");
            }
            else if (height >= 171)
            {
                Console.WriteLine($"Sinu pikkus on {height}cm");
            }
        }
    }
}
