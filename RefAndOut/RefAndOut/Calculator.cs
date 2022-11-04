namespace Program
{
    internal class Calculator
    {
        public static double Triple(ref double a)
        {
            return a = a * 3;
        }

        public static void TripleOut(double origin, out double result)
        {
            result = origin * 3;
        }
    }
}
