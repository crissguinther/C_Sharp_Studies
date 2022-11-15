using System.Collections.Generic;
using System.Globalization;
using Program.Entities;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(0);
            
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter employee #{i} data: ");
                Console.Write("Is outsourced? (Y/N): ");
                char outsourced = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'Y')
                {
                    Console.Write("Additional Charges: ");
                    double additionalCharges = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharges));
                }
                else list.Add(new Employee(name, hours, valuePerHour));                                
            }

            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}