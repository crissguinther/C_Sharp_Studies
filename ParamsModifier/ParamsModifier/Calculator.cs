namespace Program
{
    internal class Calculator
    {
        public static double Sum(params double[] args)
        {
            double sum = 0.0;

            for(int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }

            return sum;
        }
    }
}
