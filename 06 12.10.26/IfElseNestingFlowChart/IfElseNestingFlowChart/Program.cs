namespace IfElseNestingFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("auto, sedaan, ");

            string input = Console.ReadLine();
            

            if (input == "auto")
            {
                string input_suurus = Console.ReadLine();
                if (input_suurus == "sedaan")
                {
                    Console.WriteLine("valisid sedaani");
                }
                else if (input_suurus == "kabriolet")
                {
                    Console.WriteLine("valiosid kabrioletti");
                }
                else
                {
                    Console.WriteLine("valisid muu auto");
                }
            }
            else
            {
                Console.WriteLine("valisid muu sõiduki");
            }
        }
    }
}
