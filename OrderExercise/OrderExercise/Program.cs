using System.Globalization;
using Program.Entities;
using Program.Entities.Enums;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= numItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item= new OrderItem(quantity, product);
                order.AddItem(item);
            }

            Console.WriteLine(order.ToString());
        }
    }
}