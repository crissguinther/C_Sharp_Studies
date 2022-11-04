using System.Globalization;

namespace Program
{
    internal class Employee
    {
        private int _id;
        private string Name { get; set; }
        private double Sallary { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, double sallary)
        {
            _id = id;
            Name = name;
            Sallary = sallary;
        }

        public int ID
        {
            get { return _id; }

        }

        public void SallaryRaise(double percentage)
        {
            Sallary += Sallary / 100 * percentage;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Sallary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
