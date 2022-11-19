using Program.Entities;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\in.csv";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}