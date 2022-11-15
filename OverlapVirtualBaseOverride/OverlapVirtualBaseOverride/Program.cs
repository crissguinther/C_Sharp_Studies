using Program.Entities;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.0);
            SavingsAccount sacc = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc.Withdraw(10.0);
            sacc.Withdraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(sacc.Balance);
        }
    }
}