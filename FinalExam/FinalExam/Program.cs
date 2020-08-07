using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows;

namespace FinalExam
{
    class Program
    {
        private static FizzBuzz LoadConfiguration(string configuration)
        {
            string configType = ConfigurationManager.AppSettings[configuration];
            Type instance = Type.GetType(configType);
            FizzBuzz app = new FizzBuzz((UserOptionsStrategy)Activator.CreateInstance(instance));
            return app;
        }

        private static FizzBuzz ConfigHander(string[] args)
        {
            FizzBuzz program = LoadConfiguration("DefaultConfig");

            if (args.Length > 0)
            {
                if (args[0] == "custom")
                {
                    program = LoadConfiguration("UserConfig");
                }
            }

            return program;
        }

        public static void Main(string[] args)
        {
            FizzBuzz program = ConfigHander(args);

            program.InputHandler();

            Console.ReadLine();
        }
    }
}
