namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            byte state = 0;

            string valitudAuto = string.Empty;
            string skodaMudel = string.Empty;


            while (running)
            {
                if (state == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Tere! Mis autot tahad?");
                    Console.WriteLine("Meil on valikus BMW, Porsche, Audi ja Skoda");
                    valitudAuto = Console.ReadLine();
                    if (valitudAuto != string.Empty)
                    {
                        if (valitudAuto == "Skoda")
                        {
                            state = 1;
                        }
                        else
                        {
                            state = 2;
                        }
                    }
                }
                else if (state == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Mis mudel? Me pakume Kodiaqi ja Octaviat");
                    skodaMudel = Console.ReadLine();
                    state = 3;
                }
                else if (state == 2)
                {
                    Console.WriteLine("Valisid " + valitudAuto);
                } 
                else if (state == 3)
                {
                    Console.WriteLine("Valisid Skoda " + skodaMudel);
                }
            }
        }
    }
}
