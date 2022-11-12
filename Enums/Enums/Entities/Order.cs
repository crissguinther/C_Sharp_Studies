using Program.Entities.Enums;

namespace Program.Entities
{
    internal class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Moment}, {Status}";
        }
    }
}
