using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleClockObserver
{
    public interface ITimerObserver
    {
        void HundredthSecond();
        void TenthSecond();
        void Second();
        void Minute();
        void Hour();
    }
}
