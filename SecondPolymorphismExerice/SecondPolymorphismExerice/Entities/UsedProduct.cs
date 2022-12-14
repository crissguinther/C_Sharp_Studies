using System.Text;

namespace Program.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2"));
            sb.Append(" (Manufacture date : ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.Append(")");

            return sb.ToString();
        }
    }
}
