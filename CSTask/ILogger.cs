using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    public interface ILogger
    {
        void Log(Exception ex);
        void Log(String message);
    }
}
