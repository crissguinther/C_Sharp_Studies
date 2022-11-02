using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] vect = new Room[10];
            Console.Write("Enter the ammount of rooms to rent: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n Rent #" + (i + 1));
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student email: ");
                string email = Console.ReadLine();
                Boolean isRent = false;

                while (!isRent)
                {
                    Console.Write("Which room student chose: ");
                    int r = int.Parse(Console.ReadLine());
                    if (vect[r] == null)
                    {
                        vect[r] = new Room(name, email);
                        isRent = true;
                    }
                    else
                    {
                        Console.WriteLine("Room is already rented!");
                    }
                }
            }

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null) Console.WriteLine("\n Room #" + i + ": " + vect[i].ToString());

            }
        }
    }
}