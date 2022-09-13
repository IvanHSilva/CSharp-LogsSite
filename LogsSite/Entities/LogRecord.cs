using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsSite.Entities {
    public class LogRecord {
        // Attributes
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        // Constructor
        public LogRecord(string username, DateTime instant) {
        Username = username;
            Instant = instant;
        }

        // Overrides Methods
        public override int GetHashCode() {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is LogRecord)) return false;
            LogRecord other = (LogRecord)obj;
            return Username.Equals(other.Username);
        }

    }
}
