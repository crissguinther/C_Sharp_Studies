

namespace Program
{
    internal class Room
    {
        public string Name { get; set;}
        public string Email { get; set; }

        public Room() { }

        public Room(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"Room rented by {Name}, using {Email} as email";
        }
    }
}
