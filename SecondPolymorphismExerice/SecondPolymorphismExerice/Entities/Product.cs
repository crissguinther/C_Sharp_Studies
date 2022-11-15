using System.Text;

namespace Program.Entities
{
    internal class Product
    {
        public string? Name { get; protected set; }
        public double Price { get; protected set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(Price.ToString("F2"));

            return sb.ToString();
        }
    }
}
