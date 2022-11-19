using Program.Interfaces;

namespace Program.Services
{
    internal class PayPalService : IPaymentService
    {
        private readonly double monthlyTax = 0.01;


        public double InstallmentValue(int quotaNumber, double montlhyTax, double paymentTax)
        {
            throw new NotImplementedException();
        }
    }
}
