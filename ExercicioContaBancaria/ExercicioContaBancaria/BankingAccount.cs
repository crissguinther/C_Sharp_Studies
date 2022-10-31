using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
    internal class BankingAccount
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private double Balance { get; set; }

        public BankingAccount() { }

        public BankingAccount(int id, string name) : this()
        {
            ID = id;
            Name = name;
        }

        public BankingAccount(int id, string name, double balance) : this(id, name)
        {
            Deposit(balance);
        }

        public double Deposit(double value)
        {
            Balance += value;
            return Balance;
        }

        public double Withdraw(double value)
        {
            Balance -= (value + 5);
            return Balance;
        }

        public override string ToString()
        {
            return $"\n Account ID: {ID} \n Account Owner: {Name} \n Balance: ${Balance} \n";
        }
    }
}
