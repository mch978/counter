using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    /// <summary>
    /// Input, output manager
    /// </summary>
    public class ConsoleIOManager : IInputManager, IOutputManager
    {
        public string ReadInput()
        {
            Console.WriteLine("Enter sentence:");
            string sentence = Console.ReadLine();
            return sentence;
        }

        public void WriteOutput(Dictionary<string, int> result)
        {
            Console.WriteLine("Output:");
            foreach (KeyValuePair<string, int> kvp in result)
            {
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
