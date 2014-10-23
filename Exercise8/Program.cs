using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test Logger Class
            var logger = new Logger();

            logger.Log("First log.");
            logger.Log("Second log");

            foreach (var item in logger.LogPosts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
