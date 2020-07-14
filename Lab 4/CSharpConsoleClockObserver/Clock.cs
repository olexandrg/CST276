using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleClockObserver
{
    public class Clock : IDisposable
    {
        protected int originalRow;
        protected int originalColumn;
        protected Ticker ticker;
        //nullable type--allows color to be an actual value or "null"
        ConsoleColor? color;

        public Clock(int originalColumn, int originalRow, ConsoleColor? color, Ticker ticker)
        {
            this.originalRow = originalRow;
            this.originalColumn = originalColumn;
            this.color = color;
            this.ticker = ticker;
        }
        protected void WriteAt(string s, int x, int y)
        {
            ConsoleColor localcolor = Console.ForegroundColor;

            if (color != null)
            {
                Console.ForegroundColor = (ConsoleColor)color;
            }
            try
            {
                Console.SetCursorPosition(originalColumn + x, originalRow + y);
                Console.Write("{0}", s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
            if (color != null)
            {
                Console.ForegroundColor = localcolor;
            }
        }
        protected void WriteAt(int n, int x, int y, int precision)
        {

            ConsoleColor localcolor = Console.ForegroundColor;

            if (color != null)
            {
                Console.ForegroundColor = (ConsoleColor)color;
            }
            string formatString = string.Format("{{0:D{0}}}", precision);
            try
            {
                Console.SetCursorPosition(originalColumn + x, originalRow + y);
                Console.Write(formatString, n);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

            if (color != null)
            {
                Console.ForegroundColor = localcolor;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    
                }

                disposedValue = true;
            }
        }

        ~Clock()
        {
            Dispose(false);
        }

        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            // TODO: uncomment following line if the finalizer is overriden.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
