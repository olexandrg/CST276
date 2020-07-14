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
            NullHandler();
        }
        private bool done;
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public void NullHandler()
        {
            onSecondsTick?.DynamicInvoke(onSecondsTick, EventArgs.Empty);
            onTenthsTick?.DynamicInvoke(onTenthsTick, EventArgs.Empty);
            onHundredthsTick?.DynamicInvoke(onHundredthsTick, EventArgs.Empty);
        }
        public void Run()
        {
            onSecondsTick.Invoke();
            onTenthsTick.Invoke();
            onHundredthsTick.Invoke();
        }

    }
}
