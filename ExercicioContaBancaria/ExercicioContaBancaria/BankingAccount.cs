using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
    internal class BankingAccount
    {
        private int _id;
        private string Name { get; set; }
        private double _balance;

        public BankingAccount() { }

        public BankingAccount(int id, string name) : this()
        {
            _id = id;
            Name = name;
        }

        public BankingAccount(int id, string name, double balance) : this(id, name)
        {
            _balance = balance;
        }

        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                return;
            }
        }

        public double Balance
        {
            get
            {
                return _id;
            }

            set
            {
                return;
            }
        }

        public double Deposit(double value)
        {
            _balance += value;
            return _balance;
        }

        public double Withdraw(double value)
        {
            _balance -= (value + 5);
            return _balance;
        }

        public override string ToString()
        {
            return $"Account ID: {_id} \n Account Owner: {Name} \n Balance: ${_balance}";
        }
    }
}
