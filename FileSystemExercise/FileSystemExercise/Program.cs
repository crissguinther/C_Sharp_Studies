using System.Globalization;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter CSV file path: ");
                string sourcePath = Console.ReadLine();
                string targetPath = $"{Path.GetDirectoryName(sourcePath)}\\out.txt";

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.CreateText(targetPath))
                {

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        double price = double.Parse(parts[1], CultureInfo.InvariantCulture);
                        double quantity = int.Parse(parts[2]);

                        sw.WriteLine($"{parts[0]}: ${(price * quantity).ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");
            }

        }
    }
}