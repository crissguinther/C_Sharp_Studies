using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X doesn't have a value");
            }

            Console.WriteLine(y.Value);

            y = x ?? 0.0;
            Console.WriteLine(y.Value);
        }
    }
}
