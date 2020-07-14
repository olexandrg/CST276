using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpConsoleClockObserver
{
    public delegate void OnSecondsDelegate();

    public delegate void OnTenthsDelegate();

    public delegate void OnHundredthsDelegate();

    public class Ticker
    {
        public event OnSecondsDelegate onSecondsTick;
        public event OnTenthsDelegate onTenthsTick;
        public event OnHundredthsDelegate onHundredthsTick;

        public Ticker()
        {
            onSecondsTick += NullHandler;
            onHundredthsTick += NullHandler;
            onTenthsTick += NullHandler;
        }
        private bool done;
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public void NullHandler()
        {
           
        }
        public void Run()
        {
            onSecondsTick.Invoke();
            onTenthsTick.Invoke();
            onHundredthsTick.Invoke();

            int count = 0;

            while (done)
            {
                Interlocked.Increment(ref count);
                onHundredthsTick();

                if (count % 10 == 0)
                    onTenthsTick();

                if (count % 100 == 0)
                    onSecondsTick();

                if (count % 36000 == 0)
                    count = 0;
            }

        }

    }
}
