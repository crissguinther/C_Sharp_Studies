using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += price;
                vect[i] = new Product(name, price);
            }

            double avg = sum / vect.Length;

            Console.WriteLine("Average Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}