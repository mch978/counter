using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    /// <summary>
    /// Manager for counting
    /// </summary>
    public class CountManager
    {
        ILogger _logger;
        ICounter _counter;

        public CountManager(ICounter counter, ILogger logger)
        {
            if (counter == null)
                throw new ArgumentNullException("counter");
            if (logger == null)
                throw new ArgumentNullException("logger");
            _counter = counter;
            _logger = logger;
        }

        public Dictionary<string, int> Count(string sentence)
        {
            Dictionary<string, int> result=null;

            try
            {
                result = _counter.Count(sentence);
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                throw;
            }
            return result;
        }
    }
}
