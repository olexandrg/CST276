using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace CSharpConsoleClockObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            // new ticker instance
            Ticker ticker = new Ticker();

            // Instantiate clock objects
            using (SecondClock clock1 = new SecondClock(0, 1, ConsoleColor.Yellow, ticker))
            using (TenthSecondClock clock2 = new TenthSecondClock(0, 2, ConsoleColor.Green, ticker))
            using (HundredthSecondClock clock3 = new HundredthSecondClock(0, 3, ConsoleColor.Red, ticker))
            {
                // threading code
                Thread thread = new Thread(ticker.Run);
                thread.Start();
                ticker.Done = true;
                thread.Join();
            }

            Console.ReadLine();
        }
    }
}
