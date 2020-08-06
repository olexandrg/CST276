using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class ProgramMenu
    {
        FizzBuzz program;

        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("[1] Print Standard FizzBuzz");
            Console.WriteLine("[2] Print With Roman Numerals");
            Console.WriteLine("[3] Print with any multiple");
            Console.Write("\r\nSelect an option: ");

            switch(Console.ReadLine())
            {
                case "1":
                    program = new FizzBuzz(new StandardFizzBuzzStrategy());
                    program.InputHandler();
                    break;
                default:
                    return;
            }
        }
    }
}
