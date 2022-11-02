using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // We don't need to start with new command, even though
            // he accepts it.
            Point p;

            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);

            // This time, will be initialized with default values
            p = new Point();

            Console.WriteLine(p);
        }
    }
}