using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    public interface IOutputManager
    {
        void WriteOutput(Dictionary<string, int> result);
    }
}
