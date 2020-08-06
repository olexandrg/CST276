using FinalExam;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class ProgramMenu 
    {
        FizzBuzz program;

        public List<string> list;

        public void PrintMenu()
        {
            bool selection = true;

            while (selection)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("[1] Print Standard FizzBuzz");
                Console.WriteLine("[2] Create Custom output");
                Console.WriteLine("[3] Print Custom output");
                Console.WriteLine("[4] Export Custom output to file");
                Console.WriteLine("[5] Reverse list order");
                Console.WriteLine("[6] Filter Odd numbers");
                Console.WriteLine("[7] Filter Even numbers");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        program = new FizzBuzz(new StandardFizzBuzzStrategy());
                        program.InputHandler();
                        list = program.GetNewList();
                        PrintList();
                        break;
                    case "2":
                        program = new FizzBuzz(new CreateCustomListStrategy());
                        program.InputHandler();
                        list = program.GetNewList();
                        break;
                    case "3":
                        PrintList();
                        break;
                    case "4":
                        program = new FizzBuzz(new FileParserStrategy(list));
                        program.InputHandler();
                        break;
                    case "5":
                        ReverseList();
                        break;
                    case "6":
                        program = new FizzBuzz(new FilterOddStrategy());
                        program.InputHandler();
                        list = program.GetNewList();
                        break;
                    case "7":
                        program = new FizzBuzz(new FilterEvenStrategy());
                        program.InputHandler();
                        list = program.GetNewList();
                        break;
                    default:
                        selection = false;
                        break;
                }
            }
        }

        public void PrintList()
        {
            foreach (string item in list)
                Console.WriteLine(item);
        }

        public void ReverseList()
        {
            list.Reverse();
        }
    }
}
