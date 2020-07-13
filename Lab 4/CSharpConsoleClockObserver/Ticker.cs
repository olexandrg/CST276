using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpConsoleClockObserver
{
    public class Ticker
    {
        List<ITimerObserver> timers = new List<ITimerObserver>();

        private bool done;
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public void RegisterTimer(ITimerObserver clock)
        {
            timers.Add(clock);
        }
        public void UnregisterTimer(ITimerObserver clock)
        {
            timers.Remove(clock);
        }
        public void Run()
        {
            int count = 0;
            while (!done)
            {
                Interlocked.Increment(ref count);
                
                foreach (ITimerObserver timer in timers)
                {
                    timer.HundredthSecond();

                    if (count % 10 == 0)
                    {
                        timer.TenthSecond();
                    }
                    if (count % 100 == 0)
                    {
                        timer.Second();
                    }
                    if (count % 6000 == 0)
                    {
                        timer.Minute();
                    }
                    if (count % 36000 == 0)
                    {
                        timer.Hour();
                    }
                }
                if (count % 36000 == 0)
                {
                    count = 0;
                }
            }
        }       
    }
}
