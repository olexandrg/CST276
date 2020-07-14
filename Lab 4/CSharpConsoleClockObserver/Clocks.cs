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

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }
        public void Second()
        {
            DateTime dt = DateTime.Now;

            WriteAt(dt.Hour, 0, 0, 2);
            WriteAt(":", 2, 0);
            WriteAt(dt.Minute, 3, 0, 2);
            WriteAt(":", 5, 0);
            WriteAt(dt.Second, 6, 0, 2);
        }
     
    }

    public class HundredthSecondClock : Clock
    {
        public HundredthSecondClock(int originalColumn, int originalRow, ConsoleColor? color, Ticker ticker)
            : base(originalColumn, originalRow, color, ticker)
        {
            ticker.onHundredthsTick += HundredthSecond;
        }
        public void HundredthSecond()
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

    }

    public class TenthSecondClock : Clock
    {
        public TenthSecondClock(int originalColumn, int originalRow, ConsoleColor? color, Ticker ticker)
            : base(originalColumn, originalRow, color, ticker)
        {
            ticker.onTenthsTick += TenthSecond;
        }
        public void TenthSecond()
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
    }
}
