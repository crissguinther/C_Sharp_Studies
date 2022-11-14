using System.Globalization;
using System.Text;

namespace Program.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        private double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", $");
            sb.Append(Product.Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", ");
            sb.Append("Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal());

            return sb.ToString();
        }
    }
}
