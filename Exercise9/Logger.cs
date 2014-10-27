using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Logger
    {

        // Constructors
        public Logger() { LogPosts = new List<string>(); }
        // Properties
        public List<string> LogPosts { get; private set; }

        public void Log(string message)
        {
            // Add the message to a List<string>
            LogPosts.Add(message);
        }

        
    }
}
