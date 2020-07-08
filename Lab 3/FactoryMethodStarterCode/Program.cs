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
            ConsoleLoggerFactory factory = new ConsoleLoggerFactory();
            ConsoleLogger logger1 = factory.CreateLogger();

            ConsoleLogger logger2 = factory.CreateLogger(LogLevel.ERROR);
            logger2.Log(LogLevel.WARN, "Should not see this");
            logger2.Log(LogLevel.ERROR, "Error Message");
            logger2.Log(LogLevel.FATAL, "Fatal Message");

            FileLoggerFactory log_factory = new FileLoggerFactory();
            FileLogger flogger1 = log_factory.CreateLogger();
            flogger1.Log("Log message");

            FileLogger flogger2 = log_factory.CreateLogger(LogLevel.ERROR);
            flogger2.Log(LogLevel.WARN, "Should not see this");
            flogger2.Log(LogLevel.ERROR, "Error Message");
            flogger2.Log(LogLevel.FATAL, "Fatal Message");

            Console.ReadLine();
        }
    }
}
