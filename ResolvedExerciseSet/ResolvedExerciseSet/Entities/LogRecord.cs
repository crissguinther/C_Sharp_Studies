using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; } = "Anonymous";
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant)
        {
            Username = username;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException("Object is empty");
            LogRecord other = obj as LogRecord;

            return Username.Equals(other.Username);
        }
    }
}
