using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Logger
{
    public class ConsoleLoggerFactory
    {
        public ConsoleLogger CreateLogger()
        {
            ConsoleLogger logger = new ConsoleLogger();
            return logger;
        }

        public ConsoleLogger CreateLogger(LogLevel level)
        {
            ConsoleLogger logger = new ConsoleLogger(level);
            return logger;
        }
    }
}
