using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace FactoryMethodStarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleLogger logger1 = new ConsoleLogger();
            //logger1.Log("Log message");

            ConsoleLogger logger2 = new ConsoleLogger(LogLevel.ERROR);
            logger2.Log(LogLevel.WARN, "Should not see this");
            logger2.Log(LogLevel.ERROR, "Error Message");
            logger2.Log(LogLevel.FATAL, "Fatal Message");

            FileLogger flogger1 = new FileLogger();
            flogger1.Log("Log message");

            FileLogger flogger2 = new FileLogger(LogLevel.ERROR);
            flogger2.Log(LogLevel.WARN, "Should not see this");
            flogger2.Log(LogLevel.ERROR, "Error Message");
            flogger2.Log(LogLevel.FATAL, "Fatal Message");
        }
    }
}
