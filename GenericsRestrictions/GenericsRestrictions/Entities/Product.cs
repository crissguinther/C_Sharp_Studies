using System.Globalization;
using System.Text;

namespace App.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; } 
        public double Price { get; set; } 

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object? other)
        {
            if (other == null) return 1;

            Product otherProduct = other as Product;
            if (otherProduct != null) return this.Price.CompareTo(otherProduct.Price);
            else throw new ArgumentException("The other object is not a Product");
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append("");
            stringBuilder.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            return stringBuilder.ToString();
        }
    }
}
