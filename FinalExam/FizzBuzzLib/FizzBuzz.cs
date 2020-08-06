using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class FizzBuzz : IPrintIterator
    {
        private ReadResultStrategy strategy;

        public FizzBuzz()
        {
        }
        public FizzBuzz(ReadResultStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string InputHandler()
        {
            return strategy.ResultInterface();
        }

        public int InputHandler(int i)
        {
            return i;
        }
    }
}
