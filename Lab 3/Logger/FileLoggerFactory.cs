using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            FileLogger logger = new FileLogger();
            return logger;
        }

        public ILogger CreateLogger(string LogFileName)
        {
            FileLogger logger = new FileLogger(LogFileName);
            return logger;
        }

        public ILogger CreateLogger(LogLevel level)
        {
            FileLogger logger = new FileLogger(level);
            return logger;
        }

        public ILogger CreateLogger(string logFileName, LogLevel level)
        {
            FileLogger logger = new FileLogger(logFileName, level);
            return logger;
        }
    }
}
