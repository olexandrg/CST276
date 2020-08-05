using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        // Ported FizzBuzz output from C++
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz\n");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz\n"); 
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz\n");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
