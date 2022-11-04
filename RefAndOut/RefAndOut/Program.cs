using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = 10.0;
            Console.WriteLine(Calculator.Triple(ref val));

            double triple;
            Calculator.TripleOut(val, out triple);
            Console.WriteLine(triple);
        }
    }
}