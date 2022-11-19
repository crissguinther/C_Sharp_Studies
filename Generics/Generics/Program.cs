namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();


            Console.Write("How many values will you enter? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}