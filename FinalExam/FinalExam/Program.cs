using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent app = new ConcreteComponent();
            FizzDecorator fizz = new FizzDecorator();
            BuzzDecorator buzz = new BuzzDecorator();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    buzz.SetComponent(fizz);
                    buzz.ProduceOutput();
                    Console.WriteLine();
                }
                else if (i % 3 == 0)
                {
                    fizz.ProduceOutput();
                    Console.WriteLine();

                }
                else if (i % 5 == 0)
                {
                    buzz.ProduceOutput();
                    Console.WriteLine();
                }
                else
                {
                    FizzBuzz counter = new FizzBuzz();
                    Console.WriteLine(counter.InputHandler(i));
                }
                    
            }
            Console.ReadLine();
        }
    }
}
