using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class FizzBuzz : IPrintIterator
    {
        private UserOptionsStrategy strategy;

        public FizzBuzz()
        {
        }
        public FizzBuzz(UserOptionsStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void InputHandler()
        {
            strategy.ProcessUserOption();
        }

        public int InputHandler(int i)
        {
            return i;
        }
    }
}
