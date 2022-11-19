using System.Collections.Generic;

namespace Program.Entities
{
    internal class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public List<Installment> installmentList { get; private set; } = new List<Installment>();

        public Contract(int number, DateTime date)
        {
            Number = number;
            Date = date;
        }

        public double TotalValue {
            get { throw new NotImplementedException(); }
        }

        public void AddInstallment(Installment installment)
        {
            installmentList.Add(installment);
        }
    }
}
