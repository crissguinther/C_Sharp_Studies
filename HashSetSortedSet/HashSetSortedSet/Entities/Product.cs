namespace Course.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Product product)) return false;

            Product anotherProd = obj as Product;
            return Name.Equals(anotherProd.Name) && Price.Equals(anotherProd.Price);
        }
    }
}
