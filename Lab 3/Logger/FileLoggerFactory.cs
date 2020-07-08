using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLoggerFactory
    {
        public FileLogger CreateLogger()
        {
            FileLogger logger = new FileLogger();
            return logger;
        }

        public FileLogger CreateLogger(string LogFileName)
        {
            FileLogger logger = new FileLogger(LogFileName);
            return logger;
        }

        public FileLogger CreateLogger(LogLevel level)
        {
            FileLogger logger = new FileLogger(level);
            return logger;
        }

        public FileLogger CreateLogger(string logFileName, LogLevel level)
        {
            FileLogger logger = CreateLogger(logFileName, level);
            return logger;
        }
    }
}
