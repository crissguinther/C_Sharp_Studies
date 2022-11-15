namespace Program.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + $" (Customs fee: $ {CustomsFee})";
        }
    }
}
