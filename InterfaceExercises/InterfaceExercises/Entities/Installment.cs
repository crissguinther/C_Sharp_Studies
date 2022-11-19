using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Entities
{
    internal class Installment
    {
        public DateTime dueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            Amount = amount;
        }
    }
}
