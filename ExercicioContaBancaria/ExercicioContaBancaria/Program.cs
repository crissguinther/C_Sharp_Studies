using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert banking account data: ");
            Console.Write("Banking account id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Banking account owner's name: ");
            string name = Console.ReadLine();

            Console.Write("Do you want to add a initial deposit?(Y/N) ");
            char choice = Console.ReadLine()[0];
            double balance = 0;

            if (choice == 'y' || choice == 'Y')
            {
                Console.Write("How much do you want to deposit? ");
                balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            BankingAccount ba = new BankingAccount(id, name, balance);
            Console.WriteLine(ba.ToString());

            Console.Write("Enter deposit value: ");
            ba.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine(ba.ToString());

            Console.Write("Enter withdraw value: ");
            ba.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine(ba.ToString());

        }
    }
}