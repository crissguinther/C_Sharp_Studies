using System;
using System.Globalization;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>(n);

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Sallary: ");
                double sallary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee e = new Employee(id, name, sallary);
                employees.Add(e);
            }

            Console.Write("Enter the employee ID that will have a sallary increase: ");
            int currID = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.ID == currID);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                emp.SallaryRaise(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            } else
            {
                Console.WriteLine("ID does not exist!");
            }
            
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}