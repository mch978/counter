using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ConsoleIOManager consoleManager = new ConsoleIOManager();
            string sentence = consoleManager.ReadInput();
            CountManager csTask = new CountManager(new WordCounter(),new ConsoleLogger());
            Dictionary<string,int> result = csTask.Count(sentence);
            consoleManager.WriteOutput(result);

        }
    }
}
