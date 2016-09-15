using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    /// <summary>
    /// Logs error or message to console
    /// </summary>
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
