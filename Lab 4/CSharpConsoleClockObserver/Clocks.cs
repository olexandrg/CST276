using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleClockObserver
{
    public class SecondClock : Clock
    {
        public SecondClock(int originalColumn, int originalRow, ConsoleColor? color, Ticker ticker)
            : base(originalColumn, originalRow, color, ticker)
        {
            ticker.onSecondsTick += Second;
        }

        private void Second()
        {
            DateTime dt = DateTime.Now;

            WriteAt(dt.Hour, 0, 0, 2);
            WriteAt(":", 2, 0);
            WriteAt(dt.Minute, 3, 0, 2);
            WriteAt(":", 5, 0);
            WriteAt(dt.Second, 6, 0, 2);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ticker.onSecondsTick -= Second;
            }

            base.Dispose(disposing);
        }
    }

    public class HundredthSecondClock : Clock
    {
        public HundredthSecondClock(int originalColumn, int originalRow, ConsoleColor? color, Ticker ticker)
            : base(originalColumn, originalRow, color, ticker)
        {
            ticker.onHundredthsTick += HundredthSecond;
        }
        private void HundredthSecond()
        {
            DateTime dt = DateTime.Now;

            WriteAt(dt.Hour, 0, 0, 2);
            WriteAt(":", 2, 0);
            WriteAt(dt.Minute, 3, 0, 2);
            WriteAt(":", 5, 0);
            WriteAt(dt.Second, 6, 0, 2);
            WriteAt(".", 8, 0);
            WriteAt(dt.Millisecond / 10, 9, 0, 2);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ticker.onSecondsTick -= HundredthSecond;
            }

            base.Dispose(disposing);
        }
    }

    public class TenthSecondClock : Clock
    {
        public TenthSecondClock(int originalColumn, int originalRow, ConsoleColor? color, Ticker ticker)
            : base(originalColumn, originalRow, color, ticker)
        {
            ticker.onTenthsTick += TenthSecond;
        }

        private void TenthSecond()
        {
            DateTime dt = DateTime.Now;

            WriteAt(dt.Hour, 0, 0, 2);
            WriteAt(":", 2, 0);
            WriteAt(dt.Minute, 3, 0, 2);
            WriteAt(":", 5, 0);
            WriteAt(dt.Second, 6, 0, 2);
            WriteAt(".", 8, 0);
            WriteAt(dt.Millisecond / 100, 9, 0, 1);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ticker.onSecondsTick -= TenthSecond;
            }

            base.Dispose(disposing);
        }
    }
}
