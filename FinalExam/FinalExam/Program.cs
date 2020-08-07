using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
        static void Main(string[] args)
        {
            ProgramMenu menu = new ProgramMenu();

            //FizzBuzz program = LoadConfiguration("DefaultConfig");
            FizzBuzz program = LoadConfiguration("UserConfig");

            program.InputHandler();

            Console.ReadLine();
        }
    }
}
