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
            FizzBuzz app;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    app = new FizzBuzz(new FizzBuzzStrategy());
                    app.InputHandler();
                }
                else if (i % 3 == 0)
                {
                    app = new FizzBuzz(new FizzStrategy());
                    app.InputHandler();
                }
                else if (i % 5 == 0)
                {
                    app = new FizzBuzz(new BuzzStrategy());
                    app.InputHandler();
                }
                else
                {
                    app = new FizzBuzz();
                    app.InputHandler(i);
                }
                    
            }
            Console.ReadLine();
        }
    }
}
